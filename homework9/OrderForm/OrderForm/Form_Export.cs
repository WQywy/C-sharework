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
    public partial class Form_Export : Form
    {
        public Form_Export()
        {
            InitializeComponent();
        }

        private void Form_Export_Load(object sender, EventArgs e)
        {
            string xml = PublicValue.os.Export();
            MessageBox.Show("导出成功");
            textBox1.Text = xml;
        }
    }
}
