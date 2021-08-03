using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"S = {Math.PI * diameter}\nC = {Math.PI * Math.Pow(diameter / 2, 2)}");
        }
    }
}
