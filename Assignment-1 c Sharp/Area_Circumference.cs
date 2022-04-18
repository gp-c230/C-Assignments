using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Area_Circumference
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter area_Circle");
            double area_Circle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter area_Circumference ");
            double area_Circumference = double.Parse(Console.ReadLine());

            AreaOfCircle_Circumference(radius, area_Circle, area_Circumference);

            Console.ReadKey();
        }

        public static void AreaOfCircle_Circumference(int radius, double area_Circle, double area_Circumference)
        {
            double PI_VALUE = 3.14;
            area_Circle = PI_VALUE * radius * radius;
            Console.WriteLine("Area of Circle is "+ area_Circle);
            area_Circumference = 2 * PI_VALUE * radius;
            Console.WriteLine("Area of Circumference is "+area_Circumference);

        }
    }
}
