using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first leg's length: ");
            double leg1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second leg's length: ");
            double leg2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Hypotenuse = {Math.Sqrt(leg1*leg1 + leg2*leg2)}\nS = {leg1*leg2}");

        }
    }
}
