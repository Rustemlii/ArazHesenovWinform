using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud.Insert
{
    public class AddCategory
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);

        public AddCategory(string name)
        {
            try
            {
                con.Open();
                string script = "insert into Category values (@name)";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elave olundu");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bu adda Mal mövcuddur","Xəta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
