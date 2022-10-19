using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericFindMax
{
    public class FindMaximum<T> where T : IComparable<T>
    {
        public T firstNum, secondNum, thirdNum;
        public void FindMaxGenerics(T firstNum, T secondNum, T thirdNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.thirdNum = thirdNum;
        }

        public  void Maximum (T firstNum, T secondNum, T thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
                Console.WriteLine("{0} is greatest among all", firstNum); 
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
                Console.WriteLine("{0} is greatest among all", secondNum);
            else
                Console.WriteLine("{0} is greatest among all", thirdNum);

        }

    }

    
}
