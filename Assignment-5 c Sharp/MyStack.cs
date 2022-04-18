using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class MyStack
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Employee");
            stack.Push(67.2);
            stack.Push("Mani Raju");
            foreach (Object obj in stack)
            {
                Console.WriteLine("Different types of data" + ":" + obj);
            }
            Console.WriteLine("/---------------------------------------/");
            stack.Pop();
            
            foreach (Object obj in stack)
            {
               
                Console.WriteLine("After pop operation" + ":" + obj);
            }

            Console.ReadLine();
        }
    }
}
