using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            while (true)
            {
                Console.WriteLine("选择服务：");
                Console.WriteLine("1.添加订单");
                Console.WriteLine("2.删除订单");
                Console.WriteLine("3.查询订单");
                Console.WriteLine("4.修改订单");
                Console.WriteLine("5.所有订单概况（订单号排序）");
                Console.WriteLine("6.所有订单概况（总金额排序）");
                Console.WriteLine("7.订单序列化");
                Console.WriteLine("8.xml反序列化");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: os.CreateOrder(); break;
                    case 2: {
                            Console.WriteLine("输入要删除订单的订单号");
                            string id = Console.ReadLine();
                            os.CancelOrder(id); break;
                        } 
                    case 3: os.QueryOrder(); break;
                    case 4: os.ReviseOrder(); break;
                    case 5: os.SortbyId(); break;
                    case 6: os.SortbyTotalPrice(); break;
                    case 7: Console.WriteLine(os.Export()); break;
                    case 8: os.Import(); break;
                }
            }
            
        }
    }
}
