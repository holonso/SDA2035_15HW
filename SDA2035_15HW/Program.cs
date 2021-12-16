using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_15HW
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ap = new ArithProgression();
            ap.setStart(2);                                 // 2 - как начальное значение, менять здесь
            Console.WriteLine(ap.getNext());
            Console.WriteLine(ap.getNext());
            Console.WriteLine(ap.getNext());
            ap.reset();

            Console.WriteLine();

            ap.setStart(105);                               // 105 - как начальное значение, менять здесь
            Console.WriteLine(ap.getNext());
            Console.WriteLine(ap.getNext());
            Console.WriteLine(ap.getNext());
            ap.reset();

            Console.WriteLine();

            GeomProgression gp = new GeomProgression();
            gp.setStart(5);                                 // 5 - как начальное значение, менять здесь
            Console.WriteLine(gp.getNext());
            Console.WriteLine(gp.getNext());
            Console.WriteLine(gp.getNext());
            gp.reset();

            Console.WriteLine();

            gp.setStart(7);                                 // 7 - как начальное значение, менять здесь
            Console.WriteLine(gp.getNext());
            Console.WriteLine(gp.getNext());
            Console.WriteLine(gp.getNext());
            gp.reset();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int X;                              // начальное значение
        int i;                              // счетчик
        int A;                              // выходное значение
        const int j = 2;                    // 2 - шаг прогрессии (менять здесь)
        public void setStart(int x)
        {
            X = x;
            Console.WriteLine("Установлено новое начальное значение арифметической прогрессии = {0}", x);
        }
        public void reset()
        {
            i = 1;
            Console.WriteLine("Сброс к начальному значению");
        }
        public int getNext()
        {
            A = X + j * (++i);
            return A;
        }
    }
    class GeomProgression : ISeries
    {
        int X;                              // начальное значение
        int i;                              // счетчик
        int G;                              // выходное значение
        const int q = 2;                    // 2 - шаг прогрессии (менять здесь)
        public void setStart(int x)
        {
            X = x;
            Console.WriteLine("Установлено новое начальное значение геометрической прогрессии = {0}", x);
        }
        public void reset()
        {
            i = 0;
            Console.WriteLine("Сброс к начальному значению");
        }
        public int getNext()
        {
            G = X * (int)Math.Pow(q, (++i));
            return G;
        }
    }
}
