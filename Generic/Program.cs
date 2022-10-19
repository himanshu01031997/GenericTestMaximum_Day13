using System.Collections;
namespace GenericFindMax
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindMaximum<int>findint=new FindMaximum<int>();
            findint.Maximum(10, 20, 30);
            FindMaximum<double>finddouble=new FindMaximum<double>();
            finddouble.Maximum(10.12, 20.22, 30.22);
            FindMaximum<string> findstring = new FindMaximum<string>();
            findstring.Maximum("lakhan", "zakir", "ramuu");

        }
    }
}