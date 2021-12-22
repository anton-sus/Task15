using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ar = new ArithProgression();
            Console.WriteLine("установите начальное значение");
            int x = Convert.ToInt32(Console.ReadLine());
            ar.setStart(x);
            Console.WriteLine("установите шаг");
            int s = Convert.ToInt32(Console.ReadLine());
            ar.setStep(s);
            Console.WriteLine("арифм. прогрессия:");
            Console.WriteLine(ar.getNext());
            Console.WriteLine(ar.getNext());
            Console.WriteLine(ar.getNext());
            Console.WriteLine("сброс");
            ar.reset();
            Console.WriteLine(ar.getNext());

            GeomProgression geom = new GeomProgression();
            Console.WriteLine("\nгеом. прогрессия:");
            geom.setStart(x);
            geom.setStep(s);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine("сброс");
            geom.reset();
            Console.WriteLine(geom.getNext());
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
        int current;
        int step;
        int first;

        public void setStart(int x)
        {  
            first = x;
            current = first;
        }

        public int getNext()
        {    
            current += step;
            return current;
        }


        public void setStep(int s)
        {
            step = s;
        }

        public void reset()
        {
            current = first;
        }
    }
    class GeomProgression : ISeries
    {
        int current;
        int step;
        int first;

        public void setStart(int x)
        {
            first = x;
            current = first;
        }

        public int getNext()
        {
            current *= step;
            return current;
        }


        public void setStep(int s)
        {
            step = s;
        }

        public void reset()
        {
            current = first;
        }
    }
}