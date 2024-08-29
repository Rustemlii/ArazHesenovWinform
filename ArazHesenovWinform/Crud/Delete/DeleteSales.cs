using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazHesenovWinform.Crud.Delete
{
    public class DeleteSales
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public DeleteSales(string ad,string tip)
        {
            try
            {
                con.Open();
                string script = "DELETE FROM Sales WHERE Ad=@ad And Tip=@tip";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@ad", SqlDbType.NVarChar).Value=ad;
                cmd.Parameters.AddWithValue("@tip", SqlDbType.NVarChar).Value=tip;
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
