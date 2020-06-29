using System;
using System.Collections.Generic;

namespace dotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of the List<T> class
            List<int> nums = new List<int>();

            int num = 0;

            //Creating an instance of the Person class
            Person p = new Person("Cruz", "1234 Acorn Ln");            

            //Object Initializer Syntax
            Person p2 = new Person() { Name = "John", Address = "4321 Nroca Ln" };            

            Console.WriteLine($"p1's Name: {p.Name} p1's Address: {p.Address}");
            Console.WriteLine(p2.Name);
        }
    }
}
