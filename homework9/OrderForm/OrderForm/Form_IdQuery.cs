using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;

namespace OrderForm
{
    public partial class Form_IdQuery : Form
    {
        public Form_IdQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string result = "";
            var query = PublicValue.os.QueryOrderbyId(textBox1.Text);
            if (query == null)
                MessageBox.Show("不存在符合要求的订单");
            else
            {
                foreach (Order.Order o in query)
                    result += o.ToString();
                textBox2.Text = result;
            }*/
            string Id = textBox1.Text;
            using (var db = new OrderDB())
            {
                Order.Order order = db.Order.Include("Items").
                  SingleOrDefault(o => o.OrderId == Id);
                textBox2.Text = order.ToString();
            }
        }
    }
}
