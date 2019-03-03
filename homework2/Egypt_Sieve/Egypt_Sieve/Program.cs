using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egypt_Sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are prime number from 2 to 100:");

            bool []is_prime = new bool[101];//素数位对应值false，合数位对应值true
            for(int i=2;i<is_prime.Length;i++)
            {
                if(is_prime[i]==false)
                {
                    Console.WriteLine(i);  //打印素数
                    for(int j=i*i;j<=100;j+=i)
                    { is_prime[j] = true; }//将素数i的倍数去除
                }
            }

           
        }
    }
}
