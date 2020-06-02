using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles;
            float amtGas;
            float milesPerGallon;
            string input;

            Console.WriteLine("How many miles have you driven?");
            input = Console.ReadLine();
            miles = float.Parse(input);

            Console.WriteLine("How much gas has the vehicle used for those miles?");
            input = Console.ReadLine();
            amtGas = float.Parse(input);

            milesPerGallon = miles / amtGas;
            Console.WriteLine("Your vehicle is getting " + milesPerGallon + "miles per gallon.");
        }
    }
}
