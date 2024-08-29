using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazHesenovWinform.Crud.GetAllForm
{
    public class GetPriceForForm
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public GetPriceForForm(ComboBox tip, ComboBox price)
        {

            try
            {
                con.Open();
                string script1 = "SELECT Qiymet FROM Products WHERE Id=@Id";
                SqlCommand cmd1 = new SqlCommand(script1, con);
                cmd1.Parameters.AddWithValue("@Id",Convert.ToInt32( tip.SelectedValue));
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                price.DisplayMember = "Qiymet";
                price.ValueMember = "Id";
                price.DataSource = dt;
                con.Close();
            }
            catch (Exception ex1)
            {
                // MessageBox.Show(ex1.Message);
            }
        }
    }
}
