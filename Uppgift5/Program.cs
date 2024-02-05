using System;
using System.Collections.Generic;
namespace uppgift5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            Console.WriteLine("Skriv in dina senaste månadslöner, skriv 0 när du vill sluta");
            bool a = double.TryParse(Console.ReadLine(), out double n);
            while (n != 0 || !a)
            {
                if (a == true)
                {
                    list.Add(n);
                    a = double.TryParse(Console.ReadLine(), out n);
                }
                while (a == false)
                {
                    Console.Write("Ogiltigt svar, skriv igen: ");
                    a = double.TryParse(Console.ReadLine(), out n);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Medellönen är: " + MedelLön(list) + "kr i månadslön");
            Console.WriteLine(MedianLön(list));
            Console.ReadKey();
        }
        static double MedelLön(List<double> list)
        {
            double summa = 0;
            foreach (double n in list)
            {
                summa += n;
            }
            return summa/list.Count;
        }
        static string MedianLön(List<double> list)
        {
            list.Sort();
            if (list.Count % 2 != 0)
            {
                return $"Medianlönen är: {list[list.Count / 2]}kr i månadslön";
            }
            else
            {
                return $"Medianlönen är: {list[(list.Count / 2) - 1]}kr och {list[list.Count / 2]}kr i månadslön";
            }
        }
    }
}