using MyAppModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppData
{
   public class DataClass
    {
        public static void DataMethod(ModelClass txt, string sp)
        {

            string connectionstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();


            cmd.Parameters.AddWithValue("@name", txt.namep);
            cmd.Parameters.AddWithValue("@sale", txt.salep);
            cmd.Parameters.AddWithValue("@purchase", txt.purchasep);
            cmd.Parameters.AddWithValue("@available", txt.availablep);
            cmd.Parameters.AddWithValue("@stockdate", txt.datap);
            cmd.ExecuteNonQuery();




        }
    }
}
