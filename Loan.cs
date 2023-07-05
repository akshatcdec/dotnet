using System;
using System.Xml.Linq;

namespace RBILoanApplication
{
    public abstract class Loan
    {
        public string Name;//we have variable
        public string Age;
        public Loan(string name, string age) //can have constructor
        {
            Name = name;
            Age = age;
        }
        public void PrintRBIMessage() //non abstract method
        {
            Console.WriteLine("THIS IS RBI LOAN DEPARTMENT");
        }
        public abstract void PrintRBIMessage(string message);// Polymorphism
        public abstract void PrintLoanDetails(); // abstract method
    }
    public class HomeLoan : Loan
    {
        public string Salary;
        public string cibilScore;
        public string PANCard;
        public HomeLoan(string name, string age) : base(name, age)
        {

        }
        public HomeLoan(string salary, string cibilScore, string pANCard, string name, string age) : base(name, age)
        {
            this.Salary = salary;
            this.cibilScore = cibilScore;
            this.PANCard = pANCard;
        }

        public override void PrintLoanDetails()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Salary:" + Salary);
            Console.WriteLine("Cibil Score:" + cibilScore);
            Console.WriteLine("Pan Card:" + PANCard);
        }

        public override void PrintRBIMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
