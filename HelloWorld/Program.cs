using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;
        public int Div(int a, int b) => a / b;
    }
}
