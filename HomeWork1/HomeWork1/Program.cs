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


        //5.Даны целые числа A и B. Найти произведение всех чётных целых чисел от A до B включительно.
        static double chetnprod(int a, int b)
        {
            double c = 1;
            if (b < a)
                (a, b) = (b, a);
            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                    c *= i;
            }
            return c;
        }/*LOG Введите два числа:2 
            5
            произведение всех чётных целых чисел от A до B=8
           LOG Введите два числа:5
            2
            произведение всех чётных целых чисел от A до B=8*/


        // Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0.
        // Вычислить количество чисел в наборе, меньших K, а также количество чисел, делящихся на K нацело
        static (int, int) lessK(List<int> l, int k)
        {
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] < k)
                    c1 += 1;
                if ((l[i] % k) == 0)
                    c2 += 1;
            }
            return (c1 - 1, c2 - 1);//чтобы не посчитать ноль вычтем 1
        }
        //LOG Введите числo:5
        //Введите набор ненулевых целых чисел:10 3 2 1 0
        //количество чисел, меньших K; делящихся на K нацело:(3, 1)

        
        //Описать перечислимый тип Seasons (времена года). Создать метод, который по номеру месяца [1..12] возвращает время года.
        enum Season { Winter, Spring, Summer, Autumn }
        static Season GetSeason(int a)
        {
            if (a > 12 | a < 1)
                throw new ArgumentException("неверный номер месяца!");
            switch (a)
            {
                case 1:
                case 2:
                case 12:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
            }
            return 0;
        }
        /*LOG
         Введите числo(1-12):9
         Season: Autumn
         Введите числo(1-12):2
         Season: Winter
         Введите числo(1-12):30
         неверный номер месяца!
         */
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

            /*Console.Write("Введите два числа:");
        int x3 = Convert.ToInt16(Console.ReadLine());
        int y3 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"произведение всех чётных целых чисел от A до B={ chetnprod(x3, y3)}");*/

            /*Console.Write("Введите числo:");
            int k = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите набор ненулевых целых чисел:");
            List<int> l= new List<int>();
            int c = 1;
            while (c != 0) 
            {
                c = Convert.ToInt16(Console.ReadLine());
                l.Add(c);
            }
            Console.WriteLine($"количество чисел, меньших K; делящихся на K нацело:{lessK(l,k)}");*/


            /*Console.Write("Введите числo(1-12):");
            int s = Convert.ToInt16(Console.ReadLine());
            try { GetSeason(s); }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            Console.WriteLine($"Season: {GetSeason(s)}");*/
        }
    }
}
