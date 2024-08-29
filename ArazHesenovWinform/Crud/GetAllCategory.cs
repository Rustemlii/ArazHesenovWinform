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
    public class GetAllCategory
    {
        SqlConnection con=new SqlConnection(MySqlConnection.ConSql);

        public GetAllCategory(DataGridView d)
        {
            try
            {
                con.Open();
                string script = "Select * from Category";
                SqlCommand cmd = new SqlCommand(script, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
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
