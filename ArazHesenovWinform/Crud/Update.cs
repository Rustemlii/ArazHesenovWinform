using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ArazHesenovWinform.Crud
{
    public class Update
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public Update(int categoryid, string type, int quantity, decimal price, string id,  DataGridView d)
        {
            try
            {
                con.Open();
                string script = "Update Products set Tip=@type,Say=@quantity,Qiymet=@price ,CategoryId=@categoryid where Id=@id";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@categoryid", categoryid);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                GetAllProduct get = new GetAllProduct(d);
                MessageBox.Show("Deyisiklikler qeyde alindi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
