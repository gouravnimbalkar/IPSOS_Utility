using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using IPSOS_TestDataGenerator.Objects;


namespace IPSOS_TestDataGenerator.Utilities
{
    public static class SQLOperations
    {  
        //Server,DB,Userid,password info
        public static readonly string _connectionString = Resources.TestRunConstants.DatabaseconnectionString;
        //Sql Query
        public static readonly string _insertNeoCodeCommand = Resources.TestRunConstants.InsertNeoCodeCommand;                          

        public static void insertneocode()
        {
              
            List<NeoCode> neoCodeList = ExcelReader.getNeoCodes(); //Fetching List of Idneo and NeoCode
            int _affectedRows = 0;
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                using (conn)
                {
                    foreach (NeoCode currentNeoCode in neoCodeList)
                    {
                        SqlCommand insertCommand = new SqlCommand(_insertNeoCodeCommand, conn);        //insert command
                        insertCommand.Parameters.Add(new SqlParameter("@ID_Neo", currentNeoCode.ID));
                        insertCommand.Parameters.Add(new SqlParameter("@neo_code", currentNeoCode.NCode));
                        insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Inserted: IdNeo , NeoCode");
                        _affectedRows++;
                    }
                }

            }
            catch (Exception SQLEx)
            {
                Console.WriteLine("Error occured while executing insert command. Error: " + SQLEx.Message);
                throw SQLEx;
            }
            finally
            {
                conn.Close();
            }

            Console.WriteLine("Commands executed! Total rows affected are: " + _affectedRows);
            
        }

    }

}
