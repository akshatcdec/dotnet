using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    public class BaseClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is base class Message");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void PrintMessage()
        {
            Console.WriteLine("This is Child class Message");
        }
    }
}
