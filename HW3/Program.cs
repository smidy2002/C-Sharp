using System;
using System.Text;
namespace MyApp
{
    internal class Program
    {
        static void Main()
        {
            Point a = new();
            a.x = 1;
            a.y = 2;
            a.z = 3;
            Point b = new();
            b.x = 3;
            b.y = 2;
            b.z = 1;
            Calculator.CalculateDistance(a,b);
            //Informer.PrintToConsole();
        }
        public struct Point 
        {
            public int x;
            public int y;
            public int z;
        }
        class Informer
        {
             protected static void PrintToConsole(string data)
            {
                Console.WriteLine(data);
            }
        }
        class Calculator : Informer
        {
             public static void CalculateDistance(Point p1, Point p2)
            {
                double range = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y) + (p1.z - p2.z)* (p1.z - p2.z));
                Calculator.PrintToConsole(range.ToString());
            }
        }
    }
}