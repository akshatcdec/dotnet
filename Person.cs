using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Person
    {
        private string Name { get; set; }
        private string City { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Your name is " + Name);
            Console.WriteLine("Your City is " + City);
        }
        public Person(string msg)
        {
            Console.WriteLine(msg);
        }
        public Person(string _city,string _name)
        {
            City = _city;
            Name = _name;
            Console.WriteLine("Base Class Paraemeter Called");
        }
    }
    class Student : Person
    {
        public string Course { get; set; }
        public Student():base("DELHI","AKSHAT")
        {
            Console.WriteLine("Derived Class Called");
        }
    }
}
