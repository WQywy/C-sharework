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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form_Create fc = new Form_Create();
            fc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_IdQuery fidq = new Form_IdQuery();
            fidq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_ShowAll fsa = new Form_ShowAll();
            fsa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_NameQuery fnq = new Form_NameQuery();
            fnq.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_GoodsQuery fgq = new Form_GoodsQuery();
            fgq.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Cancel fca = new Form_Cancel();
            fca.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_Revise fr = new Form_Revise();
            fr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PublicValue.os.orderlist.Sort();
            Form_ShowAll fsa = new Form_ShowAll();
            fsa.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PublicValue.os.orderlist.Sort((o1, o2) => (int)(o1.TotalPrice - o2.TotalPrice));
            Form_ShowAll fsa = new Form_ShowAll();
            fsa.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_Export fe = new Form_Export();
            fe.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PublicValue.os.Import();
            MessageBox.Show("导入成功");
        }
    }
}
