using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTCSharp
{
    public class BikasClass
    {
        public string Address { get; set; }

    }
    public class DelegateDemo
    {

       
        //public delegate int MyShortDelegate(int number1, int number2)

        public void CreateDelWithAnonymousMethod()
        {

            MyDelegate myDelegate = delegate (int number1, int nummber2)
                 {
                     Console.WriteLine("Anonymous method ");
                     return number1 + nummber2;
                 };

            myDelegate(5, 7);
        }
        public void CreateDelWithLambdaExpression()
        {
            MyDelegate myDelegate =  (number1, nummber2) =>
            {
                Console.WriteLine("Lambda Expressions ");
                return number1 + nummber2;
            };

            myDelegate(5, 7);
        }


        public void CallF1()
        {
            Console.WriteLine("HEY.... I AM F1");
        }
        public void CallF2()
        {
            Console.WriteLine("HEY.... I AM F2");
            throw new Exception("I do not want to be 2nd");
        }
        public void CallF3()
        {
            Console.WriteLine("HEY.... I AM F3");
        }
        public void CallF4()
        {
            Console.WriteLine("HEY.... I AM F4");
        }

        public delegate void MultiDel();


        public static void Main(string[] args)
        {
            DelegateDemo delegateDemo = new DelegateDemo();


            MultiDel multiDel = new MultiDel(delegateDemo.CallF1);
            multiDel += delegateDemo.CallF2;

            multiDel += delegateDemo.CallF3;
            multiDel += delegateDemo.CallF4;


            var delegates = multiDel.GetInvocationList();

            // array to list

            //multiDel.Invoke();



            foreach (MultiDel del in delegates)
            {
                try
                {
                    del.Invoke();
                }
                catch (Exception ex)
                {
                    //catch the exception

                    Console.WriteLine(" Exception!!!!");
                    // log exception
                    
                }
            }

            multiDel -= delegateDemo.CallF2;

            Console.WriteLine("Invoking AGAIN --- removed faulty one");
            multiDel.Invoke();
            Console.ReadLine();


            //dynamic dn = delegateDemo;
            //dn.dummyMethod();

            //delegateDemo.Add(3, 5);
            ////delegateDemo.CreateDelegate();
            //Console.ReadLine();
        }
        public delegate int MyDelegate(int number1, int number2);

        public int Add(int number1, int number2)
        {
            Console.WriteLine("Calling via Delegate");
            return number1 + number1;
        }

        public void CreateDelegate()
        {

            // Option 1 to instantiate a delegate

            DelegateDemo delegateDemo = new DelegateDemo();


            MyDelegate myDelegate1 = new MyDelegate(delegateDemo.Add);


            myDelegate1.Invoke(3, 5);

            myDelegate1(4, 6);



            // Option 2 to instante a delegate
            MyDelegate myDelegate2 = delegateDemo.Add;

            // Option 3 to instante a delegate
            MyDelegate myDelegate3 = Add;

            // Calling a method via delegate

            // invoking the delegate - option 1
            myDelegate1.Invoke(5, 7);
            // invoking the delegate - option 2
            myDelegate1(5,7);

        }
        
    }
}
