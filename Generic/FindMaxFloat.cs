using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMaxFloat
    {
        public  void MaximumFloat(double firstval, double Secondval, double thirdval)
        {
            if(firstval.CompareTo(Secondval)>0 && firstval.CompareTo(thirdval)>0||
               firstval.CompareTo(Secondval) >= 0 && firstval.CompareTo(thirdval) > 0||
               firstval.CompareTo(Secondval) > 0 && firstval.CompareTo(thirdval) >= 0)
            {
                Console.WriteLine("first value is greatest");
            }
            if (Secondval.CompareTo(firstval) > 0 && Secondval.CompareTo(thirdval) > 0 ||
               Secondval.CompareTo(firstval) >= 0 && Secondval.CompareTo(thirdval) > 0 ||
               Secondval.CompareTo(firstval) > 0 && Secondval.CompareTo(thirdval) >= 0)
            {
                Console.WriteLine("Second value is greatest");
            }
            if (thirdval.CompareTo(firstval) > 0 && thirdval.CompareTo(Secondval) > 0 ||
               thirdval.CompareTo(firstval) >= 0 && thirdval.CompareTo(Secondval) > 0 ||
               thirdval.CompareTo(firstval) > 0 && thirdval.CompareTo(Secondval) >= 0)
            {
                Console.WriteLine("third value is greatest");
            }


        }

    }
}
