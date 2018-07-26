using Lab10.Library;
using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the JRH Circle Calculator.\nEnterprise-grade circle-related calculations, at your fingertips.");
            Circle circle;
            Validator validator = new Validator();
            int circleCount = 0;
            do
            {
                circle = new Circle(Validator.GetValidRadius());
                circleCount++;
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()} square units");
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()} units");
            } while (Validator.IsRepeating());
            Console.WriteLine($"You created {circleCount} Circle object(s). Goodbye!");
            Console.Read();
        }
    }
}
