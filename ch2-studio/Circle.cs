using System;
using System.Collections.Generic;
using System.Text;

namespace ch2_studio
{
    public class Circle
    {
        public static double areaOfCircle(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 3);
        }
        public static double diameterOfCircle(double radius)
        {
            return 2 * radius;
        }
        public static double circumferenceOfCircle(double radius)
        {
            return Math.Round(2 * Math.PI * radius, 3);
        }
    }
}
