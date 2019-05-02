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
    public partial class Form_ShowAll : Form
    {
        public Form_ShowAll()
        {
            InitializeComponent();
        }

        public void Form_ShowAll_Load(object sender, EventArgs e)
        {
            string result = "";
            foreach (Order.Order o in PublicValue.os.orderlist)
                result += o.ToString();
            textBox1.Text = result;
        }
    }
}
