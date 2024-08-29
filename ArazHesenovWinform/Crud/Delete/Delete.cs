using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud.Delete
{
    public class Delete
    {
            SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
            public Delete(int id)
            {
                try
                {
                    con.Open();
                    string script = "DELETE FROM Products WHERE Id=@ID";
                    SqlCommand cmd = new SqlCommand(script, con);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silindi");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }
}
