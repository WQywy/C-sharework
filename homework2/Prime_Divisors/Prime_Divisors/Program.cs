using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Divisors
{

    class Program
    {
        public static void JudgePrime(int num)        //判断Num是否为素数
        {
            int count = 0;
            for(int i=1;i<=num;i++)
            {
                if (i * (num / i) == num) { count++; }
            }
            if (count == 2) { Console.WriteLine(num); }//当num仅有两个因子时，即为素数
        }

        static void Main(string[] args)
        {
            int F_num;
            Console.Write("Please input an int:");
            F_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here are the prime factors of" + F_num + ":");

            for(int i=1;i<=F_num;i++)
            {
                if (i * (F_num / i) == F_num) { JudgePrime(i); }//若i为num因数，送入方法判断是否为素数
            }
        }


    }
}
