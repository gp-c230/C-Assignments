using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class AddEmployee
    {
        static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Dhiraj");
            list.Add("Haritha");
            list.Add("Chetan");
            list.Add("Prasanna");
            list.Add("Bhuvana");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("List of employees are " + ':' + list[i]);
            }
            Console.WriteLine("/--------------------------------------------/");
            Console.WriteLine(" Total number of employees is " + ':' + list.Count);
            Console.ReadLine();
        }

    }
}
