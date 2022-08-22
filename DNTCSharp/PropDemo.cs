using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;


namespace DNTCSharp
{


    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

    }
    public class Employee
    {
        
        public string Name { get; set; }

        public string Project { get; set; }

        int empId;

        string address;

        
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }



        
        public int EmpId
        {
            get 
            
            {
                return empId;
            }
            set 
            {
                empId = value;
            }
        }
            
    }
    public class PropDemo
    {
        public static void Main()
        {
            Employee employee = new Employee();

            //MemberInfo memberInfo = typeof(Employee);

            //memberInfo.

            Type type = employee.GetType();

            PropertyInfo[] props = type.GetProperties();

            foreach (var item in props)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();


            Employee obj1 = new Employee();
            Course obj2 = new Course();



            employee.Name = "Aishwarya";
            employee.EmpId = 101;
            employee.Address = "Sholapur";
            employee.Project = "Angular";


            var name = employee.Name;
            var empId = employee.EmpId;

            var result1 = obj1 is Employee;
            var result2 = obj2 is Employee;

            var result3 = obj1 as Employee;
            //var result4 = obj2 as Employee;


            Console.WriteLine(result1);

            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(empId+ " : " + name );
            Console.ReadLine();

        }
        
        
    }

}
