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
    public partial class Form_Revise : Form
    {
        public Form_Revise()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            var query = PublicValue.os.QueryOrderbyId(textBox1.Text);
            if (query == null)
                MessageBox.Show("不存在符合要求的订单");
            else
            {
                foreach (Order.Order o in query)
                {
                    result += o.ToString();
                }
                textBox2.Text = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Order.Order o in PublicValue.os.orderlist)
            {
                if(o.OrderId.Equals(textBox1.Text))
                {
                    foreach (Goods g in o.GoodsList)
                    {
                        if (g.GoodsName == "木材")
                            g.GoodsAmount = int.Parse(textBox6.Text);
                        if (g.GoodsName == "玻璃")
                            g.GoodsAmount = int.Parse(textBox3.Text);
                        if (g.GoodsName == "圆石")
                            g.GoodsAmount = int.Parse(textBox4.Text);
                        if (g.GoodsName == "水泥")
                            g.GoodsAmount = int.Parse(textBox5.Text);
                    }
                    o.CaculateTotalPrcie();
                }
            }
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
