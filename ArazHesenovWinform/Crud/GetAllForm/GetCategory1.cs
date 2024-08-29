using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud.GetAllForm
{
    public class GetCategory1
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public GetCategory1(ComboBox d)
        {

            try
            {
                con.Open();
                string script = "Select Id,Ad from Category";
                SqlCommand cmd = new SqlCommand(script, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                d.DisplayMember = "Ad";
                d.ValueMember = "Id";
                d.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
