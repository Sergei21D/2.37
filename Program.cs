using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int
            i = 0;
            Console.Write("Введите K[1-180]:=");
            double k = Convert.ToDouble(Console.ReadLine());
            if (k >= 1) ;
            else if (k <= 180) ;
            double z = ((k - 1) % 2) * ((k - 1) % 20) / 2 + (k % 2) * ((k / 20) + 1);
            Console.Write("Введите K:=");
            double k1 = Convert.ToDouble(Console.ReadLine());
            for (int j = 10; i <= 99; i++)
                i = i + 2;
            Console.Write("Ответ:", i / 10, ":", i);
            i = i + 2;
            Console.Write(i % 10);
            Console.Write(":");
            Console.Write(i);
            Console.ReadKey();
        }
    }
}