using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
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

    //图表工厂类：工厂类
    public class ChartFactory
    {
        public static Chart CreateChart(string type)
        {
            Chart chart = null;
            if (type.Equals("histogram"))
            {
                chart = new HistogramChart();
                Console.WriteLine("初始化设置柱状图！");
            }
            else if (type.Equals("pie"))
            {
                chart = new PieChart();
                Console.WriteLine("初始化设置饼状图！");
            }
            else if (type.Equals("Line"))
            {
                chart = new LineChart();
                Console.WriteLine("初始化设置线状图！");
            }

            return chart;
        }
    }


    //客户端
    class Client
    {
        static void Main(string[] args)
        {
            Chart chart;
            chart = ChartFactory.CreateChart("histogram"); //通过静态工厂方法创建产品
            chart.display();
        }
    }
}
