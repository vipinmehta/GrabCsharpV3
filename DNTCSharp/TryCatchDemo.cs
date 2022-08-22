using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityAssembly;

namespace DNTCSharp
{
    public  class TryCatchDemo
    {
        public static void Main()
        {
            TryCatchDemo tryCatchDemoClass = new TryCatchDemo();
            int i = 5;
            tryCatchDemoClass.DivideByZero(i);

            Console.ReadLine();
        }
        public void  DivideByZero(int number)
        {
            try
            {
                int infinity = number / 0;
                Console.WriteLine(infinity);
            }
            catch (Exception ex)
            {
                string exceptionMessage = "Exception is :"+ ex.Message;
                FileSystemUtility fileSystemUtility = new FileSystemUtility();

                string pathDirectory = @"C:\Logs\";
                string fileName = "TryCatchDemoLog.txt";
                string filePath = pathDirectory + fileName;
                fileSystemUtility.CreateDirectory(pathDirectory);
                StreamWriter streamWriter = File.CreateText(filePath);

                streamWriter.Write(exceptionMessage);

                streamWriter.Close();
            }
            finally
            {
                Console.WriteLine("Finally will always be called!!!");

            }
        }

    }
}
