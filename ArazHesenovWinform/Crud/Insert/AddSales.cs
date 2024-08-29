using ArazHesenovWinform.SqlConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArazHesenovWinform.Crud.Insert
{
    public class AddSales
    {
        SqlConnection con = new SqlConnection(MySqlConnection.ConSql);
        public AddSales(string ad,string tip,int say,decimal qiymet,decimal yekun)
        {
            try
            {
                con.Open();
                string script = "INSERT INTO SALES VALUES (@ad,@tip,@say,@qiymet,@yekun,CONVERT(DATE, GETDATE()))";
                SqlCommand cmd=new SqlCommand(script,con);
                cmd.Parameters.Add("@ad",SqlDbType.NVarChar).Value=ad;
                cmd.Parameters.Add("@tip", SqlDbType.NVarChar).Value= tip;
                cmd.Parameters.Add("@say", SqlDbType.Int).Value= say;
                cmd.Parameters.Add("@qiymet", SqlDbType.Decimal).Value= qiymet;
                cmd.Parameters.Add("@yekun", SqlDbType.Decimal).Value= yekun;
                cmd.ExecuteNonQuery();
              
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
