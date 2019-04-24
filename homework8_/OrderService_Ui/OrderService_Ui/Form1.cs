using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderService_Ui
{
    public partial class Form1 : Form
    {

        public string queryCustomerName { get; set; }
        public string queryOrderId { get; set; }
        public List<Order> orders = new List<Order>();
        public List<OrderDetail> orderDetails = new List<OrderDetail>();

        public Form1()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9);
            Goods eggs = new Goods(2, "eggs", 4.99);
            Goods apple = new Goods(3, "apple", 5.59);

            OrderDetail orderDetails1 = new OrderDetail("1", apple, 8);
            OrderDetail orderDetails2 = new OrderDetail("2", eggs, 2);
            OrderDetail orderDetails3 = new OrderDetail("3", milk, 1);

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

            orders = os.orderList;
            orderDetails = order1.Details.Concat(order2.Details).ToList<OrderDetail>();
            orderDetails = orderDetails.Concat(order3.Details).ToList<OrderDetail>();

            orderBS.DataSource = orders;
            orderDBS.DataSource = orderDetails;

            queryText.DataBindings.Add("Text", this, "queryCustomerName");
            queryIdText.DataBindings.Add("Text", this, "queryOrderId");
        }

        private void queryBotton_Click(object sender, EventArgs e)
        {
            if (queryCustomerName == null || queryCustomerName == "")
            {
                orderBS.DataSource = orders;
                orderDBS.DataSource = orderDetails;
            }
            else
            {
                orderBS.DataSource =
                    orders.Where(s => s.Customer.Name == queryCustomerName);
                orderDBS.DataSource =
                    orderDetails.Where(s => s.CustomerName == queryCustomerName);
            }
        }

        private void queryIdBotton_Click(object sender, EventArgs e)
        {
            orders.RemoveAll(o => o.Id.ToString() == queryOrderId);
            orderDetails.RemoveAll(o => o.Id == queryOrderId);
            orderBS.DataSource = orders;
            orderDBS.DataSource = orderDetails;
            if (queryOrderId == null || queryOrderId == "")
            {
                orderBS.DataSource = orders;
                orderDBS.DataSource = orderDetails;
            }
            else
            {
                orderBS.DataSource =
                    orders.Where(s => s.Customer.Name != queryOrderId);
                orderDBS.DataSource =
                    orderDetails.Where(s => s.CustomerName != queryOrderId);
            }
        }

        
    }
}
