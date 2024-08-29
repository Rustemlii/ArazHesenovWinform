using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud.Insert
{
    public class AddProduct
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public AddProduct(string type, int quantity, decimal price, object categoryId)
        {
            try
            {

                con.Open();
                string script = "insert into Products (Tip,Say,Qiymet,CategoryId) values (@type,@quantity,@price,@categoryId)";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Elave olundu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
    }
}
