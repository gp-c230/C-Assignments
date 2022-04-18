using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class MyCalculator
    {

        static void Main(string[] args)
        {
            Console.WriteLine("My Calculator Application ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Press '1' for Addition ");
            Console.WriteLine("Press '2' for Subtraction ");
            Console.WriteLine("Press '3' for Multiplication ");
            Console.WriteLine("Press '4' for Division \n");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

           // int result = 0;

            if (action == 1)
            {
                 Addition(num1, num2);
            }
            else if (action == 2)
            {
                Subtraction(num1, num2);
            }
            else if (action == 3)
            {
                 Multiplication(num1, num2);
            }
            else
            {
               Division(num1, num2);
            }

            Console.ReadKey();

        }
        //Addition of two numbers
        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two Numbers is "+result);
            return result;
        }

        public static int Subtraction(int num1, int num2)
        {
            int result = num1- num2;
            Console.WriteLine("Subtraction of two numbers is " + result);
            return result;
        }

        public static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication of two numbers is " + result);
            return (result);
        }

        public static double Division( double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Division of two numbers is " + result);
            return (result);
        }

       /* public static int HighestMarks(int students1, int students2, int students3, int students4, int students5)
        {
            
           // students = new int[] { students[0], students[1], students[2], students[3], students[4] };
           int top= 0;


            return 

        }*/

        public static void SumOfAllIntegers( params int[] sum)
        {
            sum=new int[] { sum[0],sum[1],sum[2], sum[3],sum[4] };
            sum.Sum();
        }
    }
}
