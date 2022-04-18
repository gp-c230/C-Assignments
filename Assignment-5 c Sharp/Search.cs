using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Search
    {
        static void Main()
        {
            List<string> list1 = new List<string>();
            list1.Add("Haritha");
            list1.Add("Prasanna");
            list1.Add("Kalpesh");
            list1.Add("Dhiraj");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine("List of employees" + ':' + list1[i]);
            }
            Console.WriteLine("Total number of employees" + ':' + list1.Count);
            Console.WriteLine("Enter person name:");
            string X = Console.ReadLine();
            if (list1.Contains(X))
            {
                Console.WriteLine("yes " + X + " is an employee");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadLine();
        }
    }
}
