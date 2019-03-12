using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    //抽象工厂类
    public abstract class Creator
    {
        // 工厂方法
        public abstract Chart CreateChartFactory();
    }

    //柱状图工厂类：
    public class HistorgramFactory : Creator
    {
        public override Chart CreateChartFactory()
        {
            return new HistogramChart();
        }
    }

    //饼状图工厂类：
    public class PieFactory : Creator
    {
        public override Chart CreateChartFactory()
        {
            return new PieChart();
        }
    }

    //线状图工厂类：
    public class LineFactory : Creator
    {
        public override Chart CreateChartFactory()
        {
            return new LineChart();
        }
    }

}
