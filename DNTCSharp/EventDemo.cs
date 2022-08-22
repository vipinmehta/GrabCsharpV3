using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTCSharp
{
    public class EventDemo
    {

        public delegate void MyDelegate(string myMessage);

        public event MyDelegate myClick;
        public static void Main()
        {

            EventDemo eventDemo = new EventDemo();

            eventDemo.myClick += RahulMethod;

            //MyDelegate myDelegate = MyDelegateMethod;

            //EventDemo eventDemo = new EventDemo();
            //eventDemo.myClick += MyClass_myClick;

            Console.WriteLine("Hello, World!");


            Console.ReadLine();

        }

        private static void RahulMethod(string myMessage)
        {
            throw new NotImplementedException();
        }
    }
}
