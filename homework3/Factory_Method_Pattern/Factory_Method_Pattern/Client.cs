using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Method_Pattern;

namespace Factory_Method_Pattern
{
    class Client
    {
        static void Main()
        {
            Creator HistorgramFac = new HistorgramFactory();
            Creator PieFac = new PieFactory();

            Chart chart1 = HistorgramFac.CreateChartFactory();//通过工厂方法创建产品
            Chart chart2 = PieFac.CreateChartFactory();       //通过工厂方法创建产品

            chart1.display();

            chart2.display();
        }
        
    }
}
