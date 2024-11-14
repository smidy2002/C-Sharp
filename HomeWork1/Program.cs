using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("write first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Program.Add(a,b);
            Program.Sub(a, b);
            Program.Mult(a, b);
            Program.Div(a, b);
        }
        static void Add(int a, int b)
        {
            
            Console.WriteLine("result of addition is");
            Console.WriteLine(a + b);
        }
        static void Sub(int a, int b)
        {

            Console.WriteLine("result of subtraction is");
            Console.WriteLine(a - b);
        }
        static void Mult(double a, double b)
        {

            Console.WriteLine("result of multiplication is");
            Console.WriteLine(a * b);
        }
        static void Div(double a, double b)
        {

            Console.WriteLine("result of division is");
            Console.WriteLine(a / b);
        }
    }
}