using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    public abstract class Chart
    {
        public abstract void create();// 输出图是否创建成功

        public abstract void display();//显示图
    }

    //柱状图类：具体产品类
    public class HistogramChart : Chart
    {
        public override void create()
        {
            Console.WriteLine("柱状图创建成功！");
        }


        public override void display()
        {
            Console.WriteLine("显示柱状图！");
        }
    }
    //饼状图类：具体产品类
    public class PieChart : Chart
    {
        public override void create()
        {
            Console.WriteLine("饼状图创建成功！");
        }


        public override void display()
        {
            Console.WriteLine("显示饼状图！");
        }
    }
    //折线图类：具体产品类
    public class LineChart : Chart
    {
        public override void create()
        {
            Console.WriteLine("线状图创建成功！");
        }


        public override void display()
        {
            Console.WriteLine("显示线状图！");
        }
    }


}
