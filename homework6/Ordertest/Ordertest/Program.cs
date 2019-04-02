using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{

    class MainClass
    {
        public static void Main()
        {
            try
            {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");

                Goods milk = new Goods(1, "Milk", 69.9);
                Goods eggs = new Goods(2, "eggs", 4.99);
                Goods apple = new Goods(3, "apple", 5.59);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer2);
                order1.AddDetails(orderDetails1);//add details for order1
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                order2.AddDetails(orderDetails2);//add details for order2
                order2.AddDetails(orderDetails3);//add details for order3
                order3.AddDetails(orderDetails3);

                OrderService os = new OrderService();
                os.AddOrder(order2);
                os.AddOrder(order1);    
                os.AddOrder(order3);

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.QueryAllOrders();
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("\nSort orders by Id");
                orders.Sort();
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("\nSort orders by Price");
                List<Order> sortorders = orders.OrderByDescending(s => s.money).ToList<Order>();
                foreach (Order order in sortorders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("\nGetOrdersByCustomerName:'Customer2'");
                orders = os.QueryByCustomerName("Customer2");
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("\nGetOrdersByGoodsName:'eggs'");
                orders = os.QueryByGoodsName("eggs");
                foreach (Order order in orders)
                    Console.WriteLine(order);

                Console.WriteLine("\nRemove order(id=2) and qurey all");
                os.RemoveOrder(2);
                os.QueryAllOrders().ForEach(
                    od => Console.WriteLine(od));

                Console.WriteLine("订单序列化");
                os.Export("order.xml");

                Console.WriteLine("xml反序列化");
                os.Import("order.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
