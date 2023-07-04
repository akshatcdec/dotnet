using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    internal class LocalFuntion
    {
        public static void CalculateFee()
        {

            void IdCardFee()
            {
                Console.WriteLine("ID FEES");

            }
            void AdmFee()
            {
                Console.WriteLine("ADM FEES");

            }
            void TutionFee()
            {
                Console.WriteLine("Tution FEES");

            }
            Console.WriteLine("This Is caculateFee Logic");
            IdCardFee();
            AdmFee();
            TutionFee();
        }
    }
}
