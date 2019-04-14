using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        static Customer customer1 = new Customer(1, "Snow");
        static Customer customer2 = new Customer(2, "Jack");

        static Goods milk = new Goods(1, "Milk", 69.9);
        static Goods eggs = new Goods(2, "eggs", 4.99);
        static Goods apple = new Goods(3, "apple", 5.59);

        OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
        OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
        OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

        Order order1 = new Order(1, customer1);
        Order order2 = new Order(2, customer2);
        Order order3 = new Order(3, customer2);
        OrderService os = new OrderService();

        

        //static Customer customer1 = new Customer(1, "customer1");
        // Order order = new Order(1,customer1);
        [TestMethod]
        public void GetByIdTest()
        {
            os.AddOrder(order1);
            os.AddOrder(order2);
            Assert.AreSame(os.GetById(1), order1);
     
        }

        [TestMethod]
        public void WrongGetByIdTest1()
        {
            os.AddOrder(order1);
            os.AddOrder(order2);
            Assert.AreSame(os.GetById(1), order2);

        }

        [TestMethod]
        public void WrongGetByIdTest2()
        {
            os.AddOrder(order1);
            os.AddOrder(order2);
            Assert.IsNotNull(os.GetById(3));

        }

        [TestMethod]
        public void QueryAllTest()
        {
            os.AddOrder(order1);
            os.AddOrder(order2);
            
            
            Assert.IsNotNull(os.QueryAllOrders());

        }

        [TestMethod]
        public void QueryByCustomerNameTest()
        {
            List<Order> orderlist = new List<Order>();
            orderlist.Add(order2);
            orderlist.Add(order3);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreSame(os.QueryByCustomerName("Jack")[0], order2);

        }

        [TestMethod]
        public void WrongQueryByCustomerNameTest()
        {
            List<Order> orderlist = new List<Order>();
            orderlist.Add(order2);
            orderlist.Add(order3);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreSame(os.QueryByCustomerName("Snow"), order2);

        }

        [TestMethod]
        //public void QueryByCustomerNameTest()
        public void QueryByGoodsNameTest()
        {
            order1.AddDetails(orderDetails1);//add details for order1
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails2);//add details for order2
            order2.AddDetails(orderDetails3);//add details for order3
            order3.AddDetails(orderDetails3);

            List<Order> orderlist = new List<Order>();
            orderlist.Add(order2);
            orderlist.Add(order3);
            orderlist.Add(order1);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreSame(os.QueryByGoodsName("apple")[0], order1);

        }

        [TestMethod]
        public void WrongQueryByGoodsNameTest()
        {

            order1.AddDetails(orderDetails1);//add details for order1
            order1.AddDetails(orderDetails2);
            order1.AddDetails(orderDetails3);
            order2.AddDetails(orderDetails2);//add details for order2
            order2.AddDetails(orderDetails3);//add details for order3
            order3.AddDetails(orderDetails3);

            List<Order> orderlist = new List<Order>();
            orderlist.Add(order2);
            orderlist.Add(order3);
            orderlist.Add(order1);

            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            Assert.AreSame(os.QueryByCustomerName("apple"), order2);

        }

    }
}
