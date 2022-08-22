using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UtilityAssembly;


namespace DNTCSharp
{

    public class MyException : Exception
    {
        public MyException(string exceptionString)
        {
            
        }
    }
    public class ThreadingDemo
    {
        public static void Main()
        {
            
            Task task = new Task(ThreadMethod);
            Console.WriteLine("Thread Start");
            Thread thread = new Thread(ThreadMethod);
            thread.Start();
            //ThreadMethod();
            Console.WriteLine("Thread is  running");
            Console.ReadLine();
        }
        private async static void ThreadMethod()
        {
            int counter = 10000;
            for (int i = 0; i < counter; i++)
            {
                FileSystemUtility fileSystemUtility = new FileSystemUtility();
                string pathDirectory = @"C:\Logs\";
                string fileName = "TryCatchDemoLog.txt";
                string filePath = pathDirectory + fileName;
                fileSystemUtility.CreateDirectory(pathDirectory);
                StreamWriter streamWriter = File.AppendText(filePath);

                streamWriter.Write(i);

                streamWriter.Close();
            }
        }
    }
}
