using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int []num = new int[10];       //定义数组
            Console.WriteLine("Here are the random array:");
            Random Random1 = new Random();
            for(int i=0;i<num.Length;i++)
            {
                num[i] = Random1.Next(0, 101);//初始化数组
                Console.Write(num[i] + "\0");
                //if (i / 4 == 0) { Console.Write("\n"); }
            }
            int min = 100, max = 0, sum = 0;
            foreach(int j in num)
            {
                sum+=j;
                if (j < min) { min = j; }
                if (j > max) { max = j; }
            }
            Console.WriteLine("\nSum:" + sum);
            Console.WriteLine("Max:" + max);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Average:" + (Convert.ToDouble(sum)/num.Length));
        }
    }
}
