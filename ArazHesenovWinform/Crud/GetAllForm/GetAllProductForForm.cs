using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazHesenovWinform.Crud.GetAllForm
{
    public class GetAllProductForForm
    {

        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public GetAllProductForForm(ComboBox c, ComboBox p)
        {

            try
            {
                con.Open();
                string script1 = $"SELECT Id,Tip FROM Products WHERE CategoryId={Convert.ToInt32( c.SelectedValue)}";
                SqlCommand cmd1 = new SqlCommand(script1, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                p.DisplayMember = "Tip";
                p.ValueMember = "Id";
                p.DataSource = dt;//bunu hemiwe sonuncu yazmaq lazimdi
                con.Close();
            }
            catch (Exception ex1)
            {

                MessageBox.Show(ex1.Message);
            }
        }

    }
}

