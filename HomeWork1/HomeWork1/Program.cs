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


        //Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8).
        //Учитывая, что левое нижнее поле доски (1, 1) является черным, вывести, какой цвет имеет поле с данными координатами.
        static void BlackOrWhite(int x, int y)
        {
            if ((x < 1) | (x > 8) | (y < 1) | (y > 8))
            {
                throw new ArgumentException("координаты должны быть: 1-8");
            }
            if ((x + y) % 2 == 0)
                Console.WriteLine("Black");
            else
                Console.WriteLine("White");
        }
        //LOG
        //Введите координату шахматного поля:
        //1
        //2
        //White
        //LOG
        //Введите координату шахматного поля:
        //4
        //4
        //Black
        //LOG
        //Введите координату шахматного поля:
        //9
        //9
        //координаты должны быть: 1-8
        static void Main(string[] args)
        {
            //Console.Write("Введите число:");
            //int x =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"новое число={nullten(x)}");

            /*Console.WriteLine("Введите координату шахматного поля:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());          
            try { BlackOrWhite(x1, y1); }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }*/
        }
    }
}
