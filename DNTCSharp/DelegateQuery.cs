using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTCSharp
{
    class DelegateQuery
    {
        delegate void Printer(int i);

        public void printMehtod(int i)
        {
            Console.WriteLine(i);
        }
        static void Main()
        {
            List<Printer> printers = new List<Printer>();
            DelegateQuery delegateQuery = new DelegateQuery();


            int i= 0;
            for (i=0; i < 5; i++)
            {
                Console.WriteLine(i);
                //Printer printer = new Printer(delegateQuery.printMehtod);
                //printers.Add(printer);
            }

            Console.WriteLine("After loop");
            Console.WriteLine(i);
            Console.ReadLine();
            //foreach (Printer printer in printers)
            //{
            //    printer(1);
            //}
        }

        
    }

}
