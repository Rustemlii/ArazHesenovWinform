using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud
{
    public class Search
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public Search(string search,DataGridView d)
        {
            try
            {     
                con.Open();
                string script = "select Products.Id,Category.Ad,\r\nProducts.Tip,\r\nProducts.Say,\r\nProducts.Qiymet\r\nfrom Category inner join Products on Category.Id=Products.CategoryId where Category.Ad=@name";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@name", search.ToLower());
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }


        }
    }
}
