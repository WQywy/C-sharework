using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order;
namespace OrderForm
{
    public partial class Form_Create : Form
    {
        //List<Order.Order> orderlist = new List<Order.Order>();

        public Form_Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cname, id;
            id = System.Guid.NewGuid().ToString("N");
            cname = textBox1.Text;
            List<Goods> glist = new List<Goods>();
            if (int.Parse(textBox2.Text) != 0 && textBox2.Text != null)
                glist.Add(new Goods("木材", int.Parse(textBox2.Text), 18));
            if (int.Parse(textBox3.Text) != 0 && textBox3.Text != null)
                glist.Add(new Goods("玻璃", int.Parse(textBox3.Text), 15));
            if (int.Parse(textBox4.Text) != 0 && textBox4.Text != null)
                glist.Add(new Goods("圆石", int.Parse(textBox4.Text), 20));
            if (int.Parse(textBox5.Text) != 0 && textBox5.Text != null)
                glist.Add(new Goods("水泥", int.Parse(textBox5.Text), 10));
            
            Order.Order order = new Order.Order(id, cname, glist);
            foreach (Order.Order o in PublicValue.os.orderlist)
            {
                if (o.Equals(order))
                {
                    MessageBox.Show("添加失败！原因：订单明细与已有订单相同");
                    return;
                }
            }
            PublicValue.os.orderlist.Add(order);

            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                //db.Order.Attach(order);
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }

            MessageBox.Show("创建成功！订单号为" + id);
            this.Close();
        }
    }
}
