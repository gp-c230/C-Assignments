using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SumOfIntegers_Params
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5] { 1,1,1,1,1};

            SumOfInt(a);
            Console.ReadKey();
        }

        public static void SumOfInt(params int[] a )
        {
            int result = a.Sum();
            Console.WriteLine("Sum of integers using params "+result);
        }
    }
}
