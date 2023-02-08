using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("============");
            Child child = new Child(name, age);
            System.Console.WriteLine(child);
            Console.WriteLine(child.ToString());
        }
    }
}
