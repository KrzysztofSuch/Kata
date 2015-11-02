using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MoqTests.TestoweKlasy
{
    public class SamochodDataReader
    {
        public void getSamochody()
        {
            string connetionString = null;
            SqlConnection sqlCnn;
            SqlCommand sqlCmd;
            string sql = null;

            connetionString = "Data Source=KRZYSZTOFPC\\SQLEXPRESS;Initial Catalog=testDB;User ID=user1;Password=user1";
            sql = "Select * from samochod";

            sqlCnn = new SqlConnection(connetionString);
            try
            {
                sqlCnn.Open();
                sqlCmd = new SqlCommand(sql, sqlCnn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                List<Object> list = new List<object>();
                while (sqlReader.Read())
                {
                  //  MessageBox.Show(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1) + " - " + sqlReader.GetValue(2));
                     var aaa = sqlReader.GetValue(0);
                     list.Add(aaa);
                }
                sqlReader.Close();
                sqlCmd.Dispose();
                sqlCnn.Close();
            }
            catch (Exception )
            {
                //("Can not open connection ! ");
            }
        }
    }
}