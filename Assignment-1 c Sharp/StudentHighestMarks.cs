using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class StudentHighestMarks
    {
        public static void Main(String[] args)
        {
            int[] students = new int[5] {60,80,95,85,50};
           
            HighestMarks(students);
            Console.ReadKey();
        }

        public static int[] HighestMarks(int[] students)
        {
            int result = students.Max();
            Console.WriteLine("Students Highest Marks is "+result);
            return students;

        }

    }
}
