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


        //Даны числа A, B, C Вернуть количество вещественных корней квадратного уравнения
        static int korennum(double a, double b, double c)
        {
            double disc = Math.Pow(b, 2) - 4 * a * c;
            if (disc > 0)
                return (2);
            if (disc == 0)
                return (1);
            else
                return (0);
        }
        //LOG
        //Введите A,B,C(A!=0):
        //1
        //3
        //-4
        //Количество корней = 2


        //Создать функцию, которая возвращает минимум из двух переданных вещественных чисел. 
        static double min(double x, double y)
        {
            if (x > y)
                return (y);
            else
                return (x);
        }
        //LOG
        //Введите два вещественных числа:15
        //9
        //Минимум=9
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


            /*Console.WriteLine("Введите A,B,C(A!=0):");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Количество корней={korennum(a,b,c)}");*/

            /*Console.Write("Введите два вещественных числа:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Минимум={min(x2,y2)}");*/
        }
    }
}
