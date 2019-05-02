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
    public partial class Form_Cancel : Form
    {
        public Form_Cancel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = textBox1.Text;
            /*bool flag = PublicValue.os.CancelOrder(textBox1.Text);
            if (flag)
                MessageBox.Show("删除成功");
            else
                MessageBox.Show("删除失败，订单不存在");*/
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("Items").SingleOrDefault(o => o.OrderId == Id);
                db.Goods.RemoveRange(order.GoodsList);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
    }
}
