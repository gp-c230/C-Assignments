using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SwappingTwoNumbers
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            SwapTwoNumbers(num1,num2);

            Console.ReadKey();

        }

        public static void SwapTwoNumbers(int num1, int num2)
        {
            Console.WriteLine("Before Swapping");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine("After Swapping ");
            Console.WriteLine(num1);
            Console.WriteLine( num2);

        }
    }
}
