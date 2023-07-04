using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(20);
            circle._radius = 20;
            // NameParamterDemo.TestMethod(10, 20, true);//Positional Parameter
            //NameParamterDemo.TestMethod(z: false, x: 20, y: 30);//Named Parameter
            // string[] name= { "A1","RAM","SHyam","SALMAN" };
            //ParamDemo.PrintStudentName(name);
            //LocalFuntion.CalculateFee();
            Console.ReadKey();

        }
    }
}
