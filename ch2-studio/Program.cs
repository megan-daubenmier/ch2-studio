using System;

namespace ch2_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string input = Console.ReadLine();
            double radius;
            if (!double.TryParse(input, out radius))
            {
                Console.WriteLine("Error: Non-numeric value entered.");

            } else
            {
                while (radius < 0)
                {
                    Console.WriteLine("Please enter a value greater than 0.");
                    radius = double.Parse(Console.ReadLine());
                }

                double area = Circle.areaOfCircle(radius);
                double diameter = Circle.diameterOfCircle(radius);
                double circumference = Circle.circumferenceOfCircle(radius);

                Console.WriteLine("The diameter of a circle with radius " + radius + " is: " + diameter);
                Console.WriteLine("The circumference of a circle with radius " + radius + " is: " + circumference);
                Console.WriteLine("The area of a circle with radius " + radius + " is: " + area);

                Console.WriteLine("How many miles does your car travel per gallon of gas?");
                double mpg = double.Parse((Console.ReadLine()));

                double gallonsAroundCircle = circumference / mpg;

                Console.WriteLine("Your car will use " + gallonsAroundCircle + " gallons of gas to travel around a circle with radius " + radius + " miles.");
            }
        }
    }
}
