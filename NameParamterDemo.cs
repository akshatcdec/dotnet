using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    internal class NameParamterDemo
    {
        public static void TestMethod(int x, int y, bool z)
        {
           Console.WriteLine("The value of x: "+x); 
           Console.WriteLine("The value of Y: " + y);
           Console.WriteLine("The value of Z: " + z);
        }
    }
}
