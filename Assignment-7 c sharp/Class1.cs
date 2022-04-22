using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_csharp
{
    [Serializable]
    abstract class Employee
    {
        public abstract void GetDetails();
        public abstract void ShowDetails();
    }
    [Serializable]
    class Manager : Employee
    {
        public int empid;
        public string empname;

        public override void GetDetails()
        {
            Console.WriteLine("Enter Your Employess Id:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Employess Name:");
            empname = Console.ReadLine();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Your Employee Id is {0}", empid);
            Console.WriteLine("Your Employee Name  is {0}", empname);
        }
    }
    [Serializable]
    class Marketexe : Employee
    {
        public int empId;
        public string empName;
        public override void GetDetails()
        {
            Console.WriteLine("Enter Your Employee Id:");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Employee Name:");
            empName = Console.ReadLine();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Your Employee Id is {0}", empId);
            Console.WriteLine("Your Employee Name  is {0}", empName);
        }
    }
    class File_hand_q3
    {
        static void Main()
        {
            Manager manager = new Manager();
            Marketexe marketexe = new Marketexe();
            FileStream filestream = new FileStream(@"G:\C# Serialization\FilesExampleProgram.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, manager);
            Console.WriteLine();
            formatter.Serialize(filestream, marketexe);

            filestream.Close();

        }
    }
}
