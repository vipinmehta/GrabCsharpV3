using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTCSharp
{
    public class LoopsExample
    {
        public static void Main()
        {
            PrintPattern4();
            Console.ReadLine();
        }
        public static void PrintPattern1()
        {
            // 1
            // 12
            // 123
            // 1234
            // 12345
            int counter = 5;
            for (int outerLoop = 1; outerLoop <= counter; outerLoop++)
            {
                // for i 
                for (int innerLoop = 1; innerLoop <= outerLoop; innerLoop++)
                {
                    Console.Write(innerLoop.ToString());

                }
                Console.WriteLine();
            }
        }


        public static void PrintPattern3()
        {
            // *
            // **
            // ***
            // ****
            // *****
            int counter = 5;
            for (int outerLoop = 1; outerLoop <= counter; outerLoop++)
            {
                // for i 
                for (int innerLoop = 1; innerLoop <= outerLoop; innerLoop++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        public static void PrintPattern4()
        {
            // 1
            // 22
            // 333
            // 4444
            // 55555
            int counter = GetInputCounter(); //5;
            for (int outerLoop = 1; outerLoop <= counter; outerLoop++)
            {
                // for i 
                for (int innerLoop = 1; innerLoop <= outerLoop; innerLoop++)
                {
                    Console.Write(outerLoop.ToString());

                }
                Console.WriteLine();
            }
        }


        public static int GetInputCounter()
        {
            string str = Console.ReadLine();
            int counter = Convert.ToInt32(str);
            return counter;
        }
    }
}
