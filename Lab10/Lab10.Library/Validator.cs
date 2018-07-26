using System;

namespace Lab10.Library
{
    public class Validator
    {
        public Validator() { }

        public static double GetValidRadius()
        {
            string input;
            do
            {
                Console.Write("Enter the radius for the circle: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out double validDouble) && validDouble >= 0)
                {
                    return validDouble;
                }
                else
                {
                    Console.WriteLine("Invalid input. Must be a positive number (decimals allowed).");
                }
            } while (true);
        }

        public static bool IsRepeating()
        {
            do
            {
                Console.Write("Continue? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            } while (true);
        }
    }
}
