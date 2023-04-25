using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum = " + sum);

            int diff = a - b;
            Console.WriteLine("Diff = " + diff);
            int prod = a * b;
            Console.WriteLine("Prod = " + prod);
            int div = a / b;
            Console.WriteLine("Div = " + div);
            double fdiv = a / (double)b;
            Console.WriteLine("FDiv = " + fdiv);
            int rem = a % b;
            Console.WriteLine("Rem = " + rem);

            Console.ReadKey();
        }
    }
}
