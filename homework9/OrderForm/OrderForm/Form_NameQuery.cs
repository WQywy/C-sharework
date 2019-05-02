using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form_NameQuery : Form
    {
        public Form_NameQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string result = "";
            var query = PublicValue.os.QueryOrderbyCustomer(textBox1.Text);
            if (query == null)
                MessageBox.Show("不存在符合要求的订单");
            else
            {
                foreach (Order.Order o in query)
                    result += o.ToString();
                textBox2.Text = result;
            }*/
            string Name = textBox1.Text;
            using (var db = new OrderDB())
            {
                Order.Order order = db.Order.Include("Items").
                  SingleOrDefault(o => o.CustomerName == Name);
                textBox2.Text = order.ToString();
            }
        }
    }
}
