using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = System.DateTime.Now.ToLongTimeString();//计时器显示
            int i;
            int hn = DateTime.Now.Hour;//获取计时器的时数
            int mn = DateTime.Now.Minute;//获取计时器的分数
            int sn = DateTime.Now.Second;//获取计时器的秒数

            for (i = 0; i < listBox1.Items.Count; i++)
            {
                string time = listBox1.Items[i].ToString();
                int h = int.Parse(time.Substring(0, 2));//获取时
                int m = int.Parse(time.Substring(3, 2));//获取分
                int s = int.Parse(time.Substring(6, 2));//获取秒
                string msg = time.Substring(9, time.Length - 9);//获取闹钟提醒事件
                if ((h==hn)&&(m==mn)&&(s==sn))
                {
                    MessageBox.Show(msg+"开始");
                }
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string time = textBox1.Text;
            string matter = textBox2.Text;

            if(time.Length!=8)
            {
                MessageBox.Show("输入格式错误，不足位请补零", "格式错误");
                return;
            }

            else
            {
                int h = int.Parse(time.Substring(0, 2));//获取时
                int m = int.Parse(time.Substring(3, 2));//获取分
                int s = int.Parse(time.Substring(6, 2));//获取秒

                if((h<0)||(h>23))
                {
                    MessageBox.Show("小时错误");
                    return;
                }

                if ((m < 0) || (h > 59))
                {
                    MessageBox.Show("分钟错误");
                    return ;
                }

                if ((s < 0) || (h > 59))
                {
                    MessageBox.Show("秒位错误");
                    return;
                }

                string inf;
                inf = textBox1.Text + "-" + textBox2.Text;
                listBox1.Items.Add(inf);
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);//移除该闹钟
            }
        }
    }
}
