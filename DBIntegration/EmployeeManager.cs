using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBIntegration
{
    public  class EmployeeManager
    {
        static string _spGetEmployeeDepartment = "usp_GetEmployeeDepartment";
        public static void GetEmployeeDetails()
        {
            SqlConnection sqlConnection = SqlManager.GetConnection();
            string commandText = _spGetEmployeeDepartment;

            using (SqlCommand cmd = new SqlCommand(commandText, sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["EmpId"].ToString());
                    Console.WriteLine(reader["FirstName"].ToString());
                    Console.WriteLine(reader["LastName"].ToString());
                    Console.WriteLine(reader["City"].ToString());
                    Console.WriteLine(reader["DepartmentName"].ToString());
                }
                sqlConnection.Close();
            }

            Console.ReadLine();


        }
    }
}
