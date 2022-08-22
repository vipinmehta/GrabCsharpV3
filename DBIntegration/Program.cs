using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using SecondAssembly;


namespace DBIntegration
{

    public class MyClass
    {

        public static void Main() 
        {

            EmployeeManager.GetEmployeeDetails();
            //var connectionString = SqlManager.GetConnection();
            //InsertData(connectionString);

            //string query = "select * from Employee";

            //SqlConnection sqlConnection = GetConnection();
            //sqlConnection.Open();
            //DataSet  dataSet = new DataSet();   
            //SqlDataAdapter  sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            //sqlDataAdapter.Fill(dataSet);

            //SqlCommand command = new SqlCommand();
            //command.Connection = sqlConnection;
            //command.CommandText = query;

            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["EmpId"].ToString());
            //}
            //DataTable dataTable = dataSet.Tables[0];


            //List<DataRow> list = new List<DataRow>();
            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    list.Add(dr);
            //    Console.WriteLine(dr["EmpId"].ToString());
            //    Console.WriteLine(dr["FirstName"].ToString());
            //}
            //sqlConnection.Close();
            //dataSet.Tables[0].


            //Console.ReadLine();
        }
        

        
        public static void InsertData(SqlConnection sqlConnection)
        {
            
            string commandText = "usp_InsertEmployee";

            using (SqlCommand cmd = new SqlCommand(commandText, sqlConnection))
            {
                cmd.CommandType= CommandType.StoredProcedure;

                SqlParameter sqlParameter = cmd.CreateParameter();

                cmd.Parameters.Add("@EmpID", SqlDbType.Int).Value = 7001;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = "Bikash";
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = "Rai";
                cmd.Parameters.Add("@City", SqlDbType.VarChar, 50).Value = "Banglore";

                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            Console.ReadLine();


        }
    }

}