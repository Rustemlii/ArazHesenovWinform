using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud
{
    public class GetAllProduct
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public GetAllProduct(DataGridView d)
        {
            try
            {
                con.Open();
                string script = "select Products.Id,Category.Ad as [Malın adı],\r\nProducts.Tip,\r\nProducts.Say,\r\nProducts.Qiymet\r\nfrom Category inner join Products on Category.Id=Products.CategoryId";
                SqlCommand cmd = new SqlCommand(script, con);
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
