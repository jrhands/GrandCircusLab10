using System;

namespace Lab10.Library
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            private set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return $"{x:N}";
        }
    }
}
