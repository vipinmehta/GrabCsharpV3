using System;
using System.Collections.Generic;
using FirstAssembly;
using SecondAssembly;

namespace DNTCSharp
{
    public static class Utility
    {

        
        static Utility()
        {
            Console.WriteLine("I am constructor of Static Class!!!");    
        }
        public static int CalculateTax(int salary)
        {
            int tax = salary;
            return tax;
        }
        
    }
	
    #region CommentedCCode
    //public class Employee
    //{
    //    public string Department { get; set; }
    //    public int Age { get; set; }
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }

    //    public Employee()
    //    {
    //    }
    //    public Employee(string department)
    //    {
    //        this.Department = department;
    //    }
    //    public Employee(int age, string firstName, string lastName)
    //    {

    //    }

    //}
    #endregion

    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }

    }

    public class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("Child Constructor");
        }

    }
    public class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("GrandChild Constructor");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {


            //GrandChild grandChild = new GrandChild();
            
            //int result = Utility.CalculateTax(3000);
            //int result2 = Utility.CalculateTax(6000);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            Console.ReadLine();
            
            //Employee employee1 = new Employee("HR");


            //Employee employee2 = new Employee();

            //Employee employee3 = new Employee();

            //int outerLoopCounter, innerLoopCounter, k, rows;
            //Console.WriteLine("Enter number of rows");
            //rows = Convert.ToInt32(Console.ReadLine());
            //int t = rows;
            //int l = rows;

            //for (outerLoopCounter = 1; outerLoopCounter <= rows; outerLoopCounter++)
            //{
            //    for (innerLoopCounter = 1; innerLoopCounter <= outerLoopCounter; innerLoopCounter++)
            //    {
            //        l--; // l=4, rows =5

            //    }
            //    for (int i = l; i <= rows; i++)
            //    {
            //        if (i == 0)
            //        {
            //            break;
            //        }
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }

            //    Console.Write("\n");
            //    t = t - 1;
            //    l = rows;

            //}
            //Console.ReadKey();
        }


        //static void Main(string[] args)
        //{
        //    string name = null;
        //    bool? boolNightShifts = null;

        //    string str = @"C:""Index\\";

        //    string str12 = "This Class has terrific audience";
        //    string strConcat = str + str12;




        //    //int i = 5;
        //    // Can throw exception 
        //    //string str = Convert.ToString(i);

        //    // Exception will not come
        //    //Safe programming
        //    // fetching some data from database
        //    //string name = "Salman";
        //    //int.TryParse(name, out int j);

        //    //int i = 5;
        //    //string iString = i.ToString();
        //    //string intStr = "5";
        //    ////Unboxing

        //    //Convert.ToUInt32(intStr);
        //    //string name = "Salman";
        //    //int lenString = name.Length;
        //    //string nameUpper = name.ToUpper();
        //    //string nameLower = name.ToLower();

        //    //Console.WriteLine(lenString);
        //    //Console.WriteLine(nameUpper);
        //    //Console.WriteLine(nameLower);


        //    //List<int> intList = new List<int>();
        //    //int[] intArray = new int[5] { 21, 41, 61, 81, 101 };

        //    //List<int> intListUser = new List<int>();

        //    //intListUser.Add(3);
        //    //intList.Add(2);


        //    //intList.AddRange(intArray);


        //    //for (int i = 0; i < intArray.Length; i++)
        //    //{
        //    //    Console.WriteLine(intArray[i]);
        //    //}
        //    //for (int i = 0; i < intList.Count; i++)
        //    //{
        //    //    Console.WriteLine(intList[i]);
        //    //}
        //    //foreach (var item in intList)
        //    //{
        //    //    intList.Remove(2, 5);
        //    //}

        //    Console.ReadLine();
        //    //int counter = 5;
                //    //Employee employee = new Employee();
        //    //employee.Age = 25;
        //    //employee.FirstName = "Shahrukh";

        //    //employee.LastName = "Khan";
        //    //string fullName = employee.FullName(employee.FirstName, employee.LastName);


        //    //// creating object of Child Class
        //    //ChildEmployee childEmployee = new ChildEmployee();



        //    //Console.WriteLine(fullName);
        //    //Console.ReadLine();

        //    //Console.ReadLine();
        //    //// nned to loop 5 times
        //    //var counter = 5;

        //    //for (int i = 1; i <= counter; i++)
        //    //{
        //    //    // for i 
        //    //    for (int j = 1; j <= i; j++)
        //    //    {
        //    //        Console.Write(j.ToString());

        //    //    }
        //    //    Console.WriteLine();
        //    //}

        //    //Console.ReadLine();




        //    //if (day == Weekday.Monday)
        //    //{
        //    //    Console.WriteLine("ohhh!!!Its Monday");
        //    //}

        //    //else if (day == Weekday.Tuesday)
        //    //{
        //    //    Console.WriteLine("Its Tuesday!!!!");
        //    //}
        //    //else if (day == Weekday.Wednesday)
        //    //{
        //    //    Console.WriteLine("Its wednesday!!!!");

        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Its wednesday!!!!");
        //    //}

        //    //string apparel = "Jeans";


        //    //switch (apparel)
        //    //{
        //    //    case "Shirt":
        //    //        {
        //    //            Console.WriteLine("Its a Shirt");
        //    //            break;
        //    //        }
        //    //    case "jeans":
        //    //        {
        //    //            Console.WriteLine("Its a Jeans");
        //    //            break;
        //    //        }
        //    //    case "Skirt":
        //    //        {
        //    //            Console.WriteLine("Its a skirt");
        //    //            break;
        //    //        }
        //    //    default:
        //    //        {
        //    //            Console.WriteLine("Its a default case");
        //    //            break;
        //    //        }
        //    //}
        //    //Console.ReadLine();




        //    //Console.WriteLine("Hello World!");
        //    //string fullName = FirstAssembly.MyClass.MyMethod("Akshay", "Kumar");
        //    //Console.WriteLine(fullName);

        //}

        
    }
}
