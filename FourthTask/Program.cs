using System;
namespace FourthTask
{
    class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                var result = "You entered neither \"1\" nor \"2\"";
                Console.Write("\nEnter either \"1\" or \"2\" and press Enter: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter circle's diameter: ");
                        var diameter = Convert.ToDouble(Console.ReadLine());
                        result = $"S = {Math.PI * diameter}\nC = {Math.PI * Math.Pow(diameter / 2, 2)}";
                        break;

                    case "2":
                        Console.Write("Enter first leg's length: ");
                        var leg1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter second leg's length: ");
                        var leg2 = Convert.ToDouble(Console.ReadLine());
                        result = $"Hypotenuse = {Math.Sqrt(leg1 * leg1 + leg2 * leg2)}\nS = {leg1 * leg2}";
                        break;
                }

                Console.WriteLine(result);
                Console.WriteLine("To exit program press \"Q\", to continue press any other key");
            } while (Console.ReadKey().Key.ToString().ToLower() != "q");
        }
    }
}
