using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Circle
    {
        public const double PI = Math.PI;
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public string FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }

        public double CalculateCircumference()
        {
            double circumference = PI * (radius * 2);
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            double area = PI * (radius * radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }
    }
}
