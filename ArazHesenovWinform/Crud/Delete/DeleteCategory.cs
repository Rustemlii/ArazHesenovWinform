using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArazHesenovWinform.SqlConnect;

namespace ArazHesenovWinform.Crud.Delete
{
    public class DeleteCategory
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);

        public DeleteCategory(int id, DataGridView d)
        {

            try
            {
                con.Open();
                string script = "Delete from Category where Id=@id";
                SqlCommand cmd = new SqlCommand(script, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Silindi", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllCategory get = new GetAllCategory(d);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bu Mal satışda mövcuddur\nBu Malı silmək istəyirsinizsə əvvəcə satışda olan formasını\nSilin","Xəta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
