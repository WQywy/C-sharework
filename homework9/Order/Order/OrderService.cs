using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Data.Entity;

namespace Order
{
    public class OrderService
    {
        public List<Order> orderlist = new List<Order>();
        public void CreateOrder()
        {
            string cname, id, gname;
            int n, i, gn;
            float gprice;
            id = System.Guid.NewGuid().ToString("N");
            Console.WriteLine("输入客户姓名：");
            cname = Console.ReadLine();
            List<Goods> glist = new List<Goods>();
            Console.WriteLine("需要几种货物？");
            n = int.Parse(Console.ReadLine());
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("输入第"+ ( i + 1) + "种货物名称：");
                gname = Console.ReadLine();
                Console.WriteLine("输入第" + (i + 1) + "种货物数量：");
                gn = int.Parse(Console.ReadLine());
                Console.WriteLine("输入第" + (i + 1) + "种货物价格：");
                gprice = float.Parse(Console.ReadLine());
                Goods goods = new Goods(gname, gn, gprice);
                glist.Add(goods);
            }
            Order order = new Order(id, cname, glist);
            foreach(Order o in orderlist)
            {
                if (o.Equals(order))
                {
                    Console.WriteLine("添加失败！原因：订单明细与已有订单相同");
                    return;
                }
            }
            orderlist.Add(order);
            Console.WriteLine("创建成功！订单号为" + id);
        }

        public void DisplayOrder(Order o)
        {
            Console.WriteLine(o.ToString());
        }

        public void QueryOrder()
        {
            Console.WriteLine("1.根据订单号查询");
            Console.WriteLine("2.根据客户名查询");
            Console.WriteLine("3.根据货物名查询");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        string id;
                        Console.WriteLine("输入要查询的订单号：");
                        id = Console.ReadLine();
                        var query = QueryOrderbyId(id);
                        foreach (Order o in query)
                            DisplayOrder(o);
                        break;
                    }
                case 2:
                    {
                        string cname;
                        Console.WriteLine("输入要查询的客户名：");
                        cname = Console.ReadLine();
                        var query = QueryOrderbyCustomer(cname);
                        foreach (Order o in query)
                            DisplayOrder(o);
                        break;
                    }
                case 3:
                    {
                        string gname;
                        Console.WriteLine("输入要查询的货物名：");
                        gname = Console.ReadLine();
                        var query = QueryOrderbyGoods(gname);
                        foreach (Order o in query)
                            DisplayOrder(o);
                        break;
                    }
            }
        }

        public IEnumerable<Order> QueryOrderbyId(string id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("Items").
                  SingleOrDefault(o => o.Id == Id);
            }
            var query = orderlist.Where(o => o.OrderId.Equals(id));
            if (query.FirstOrDefault() == null)
            {
                Console.WriteLine("订单号不存在！");
                return null;
            }
            else
                return query;
        }

        public IEnumerable<Order> QueryOrderbyCustomer(string cname)
        {
            var query = orderlist.Where(o => o.CustomerName.Equals(cname));
            if (query.FirstOrDefault() == null)
            {
                Console.WriteLine("客户名不存在！");
                return null;
            }
            return query;
        }

        public IEnumerable<Order> QueryOrderbyGoods(string gname)
        {
            var query = orderlist.Where(o => o.ToString().Contains(gname));
            if (query.FirstOrDefault() == null)
            {
                Console.WriteLine("货物不存在！");
                return null;
            }
            else
                return query;
        }

        public bool ReviseOrder()
        {
            string id;
            try
            {
                Console.WriteLine("输入要修改的订单号：");
                id = Console.ReadLine();
                foreach (Order i in orderlist)
                {
                    if (i.OrderId == id)
                    {
                        Console.WriteLine("1.添加货物");
                        Console.WriteLine("2.删除货物");
                        Console.WriteLine("3.修改货物数量");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1: AddGoods(i); break;
                            case 2: RemoveGoods(i); break;
                            case 3: ReviseAmout(i); break;
                        }
                        Console.WriteLine("修改成功！");
                        return true;
                    }
                }
                throw new System.Exception();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("订单号不存在！");
                return false;
            }
        }

        public void AddGoods(Order o)
        {
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            Console.WriteLine("输入货物数量：");
            int gamount = int.Parse(Console.ReadLine());
            Console.WriteLine("输入货物价格：");
            float gprice = float.Parse(Console.ReadLine());
            Goods g = new Goods(gname, gamount, gprice);
            o.GoodsList.Add(g);
            o.CaculateTotalPrcie();
        }
        public void RemoveGoods(Order o)
        {
            Goods gcancel = new Goods(" ", 0, 0);
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            foreach(Goods g in o.GoodsList)
            {
                if (gname == g.GoodsName)
                    gcancel = g;
            }
            o.GoodsList.Remove(gcancel);
            o.CaculateTotalPrcie();

        }
        public void ReviseAmout(Order o)
        {
            Console.WriteLine("输入货物名称：");
            string gname = Console.ReadLine();
            Console.WriteLine("输入修改后的货物数量：");
            int gamount = int.Parse(Console.ReadLine());
            foreach (Goods g in o.GoodsList)
            {
                if (gname == g.GoodsName)
                    g.GoodsAmount = gamount;
            }
            o.CaculateTotalPrcie();
        }

        public bool CancelOrder(string id)
        {
            foreach (Order i in orderlist)
            {
                if (i.OrderId == id)
                {
                    orderlist.Remove(i);
                    Console.WriteLine("删除成功！");
                    return true;
                }
            }
            return false;
        }

        public void SortbyId()
        {
            orderlist.Sort();
            foreach (Order o in orderlist)
                DisplayOrder(o);
        }

        public void SortbyTotalPrice()
        {
            orderlist.Sort((o1, o2)=>(int)(o1.TotalPrice - o2.TotalPrice));
            foreach (Order o in orderlist)
                DisplayOrder(o);
        }

        public string Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            String xmlFilename = "order.xml";
            FileStream fs = new FileStream(xmlFilename, FileMode.Create);
            xmlser.Serialize(fs, orderlist);
            fs.Close();
            string xml = File.ReadAllText(xmlFilename);
            return xml;
        }

        public static Order DESerializer<Order>(string filePath) where Order : class
        {
            if (!File.Exists(filePath))
                Console.WriteLine("xml文件不存在！");
            using (StreamReader reader = new System.IO.StreamReader(filePath))
            {
                 XmlSerializer xs = new XmlSerializer(typeof(Order));
                return xs.Deserialize(reader) as Order;
            }
        }

        public void Import()
        {
            string path = "order.xml";
            List<Order> olist = DESerializer<List<Order>>(path);
            foreach (Order o in olist)
            {
                DisplayOrder(o);
                orderlist.Add(o);
            }
        }
    }
}
