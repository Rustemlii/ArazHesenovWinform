using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace ArazHesenovWinform.Crud.GetAllForm
{
    public class GetSales
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public GetSales(DataGridView d,DateTimePicker start,DateTimePicker end)
        {
            try
            {
                con.Open();
                string script = @"SELECT
                      Ad as [Malın adı],
                      Tip as Tipi,
                      SUM(Say) AS Sayı,
                      Qiymet AS Qiymeti,
                      SUM(Yekun) AS [Toplam Yekun],
                      MIN(SaleDate) as Tarix 
                  FROM
                      Sales
                  WHERE
                      SaleDate BETWEEN @start AND @end
                  GROUP BY
                      Ad, Tip, Qiymet";
              
        
                SqlCommand cmd=new SqlCommand(script, con);
                cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start.Value.Date.Add(new TimeSpan(0, 0, 0)); //Avtomatik default olarak bugunun tarixin verdim
                cmd.Parameters.Add("@end", SqlDbType.DateTime).Value = end.Value.Date.Add(new TimeSpan(23, 59, 0));
                SqlDataAdapter sda=new SqlDataAdapter(cmd);
                DataTable dt=new DataTable();
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
