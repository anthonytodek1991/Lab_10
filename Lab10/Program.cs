using System;

namespace Lab10
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Please enter the radius of a circle!");
            double userInput = double.Parse(Console.ReadLine());

            Circle myCircle = new Circle(userInput);

            Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}");
            Console.WriteLine($"Circumference Formatted! {myCircle.CalculateFormattedCircumference()}");

            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");
        }
    }
}
