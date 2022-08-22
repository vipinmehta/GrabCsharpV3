using System;
using System.Collections;
using System.Collections.Generic;

namespace DNTCSharp
{
    public class Order : IComparable<Order>
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderType { get; set; }

        public string BrandName { get; set; }

        public float Price { get; set; }

        public int CompareTo(Order other)
        {
            if (this.OrderId > other.OrderId)
            {
                return 1;
            }
            else if (this.OrderId < other.OrderId)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class CollectionDemo
    {
        public static int CompareOrder(Order order1, Order order2)
        {
            if (order1.Price > order2.Price)
            {
                return 1;
            }
            else if (order1.Price < order2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void Main()
        {
            List<Order> lstOrders = new List<Order>();
            Order order1 = new Order();
            order1.OrderId = 601;
            order1.OrderName = "S20";
            order1.OrderType = "Mobile";
            order1.BrandName = "Samsung";
            order1.Price = 40000.00f;
            Order order2 = new Order();
            order2.OrderId = 501;
            order2.OrderName = "Pixal 6";
            order2.OrderType = "Mobile";
            order2.BrandName = "Google";
            order2.Price = 50000.00f;

            Order order3 = new Order();
            order3.OrderId = 501;
            order3.OrderName = "Pixal 6";
            order3.OrderType = "Mobile";
            order3.BrandName = "Google";
            order3.Price = 60000.00f;

            lstOrders.Add(order1);
            lstOrders.Add(order2);
            lstOrders.Add(order3);
            Console.WriteLine("Sorting the orders.....");
            Comparison<Order> comparison = CompareOrder;


            lstOrders.Sort(comparison);
            
            foreach (Order order in lstOrders)
            {
                Console.Write("Order Id: " + order.OrderId );
                Console.Write(" Name : " + order.OrderName);
                Console.Write(" Price : " + order.Price);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
