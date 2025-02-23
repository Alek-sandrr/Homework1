using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        //Дано трехзначное число. Обнулить в нем разряд десятков.
        static int nullten(int x) => x / 100 * 100 + x % 10;
        //LOG1
        //Введите число:123
        //новое число = 103
        static void Main(string[] args)
        {
            //Console.Write("Введите число:");
            //int x =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"новое число={nullten(x)}");
        }
    }
}
