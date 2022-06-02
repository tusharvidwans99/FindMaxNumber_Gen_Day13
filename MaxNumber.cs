using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class MaxNumber
    {

        public int MaxNumberIs(int firstvalue, int secondvalue, int thirdvalue)
        {

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(firstvalue) > 0)
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine("first value, second value & third value are same.");
                return 0;
            }

        }

        public double MaxNumberIs(double firstvalue, double secondvalue, double thirdvalue)
        {

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(firstvalue) > 0)
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine("first value, second value & third value are same.");
                return 0;
            }

        }

        public string MaxNumberIs(string firstvalue, string secondvalue, string thirdvalue)
        {

            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(thirdvalue) > 0 && secondvalue.CompareTo(firstvalue) > 0)
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            else
            {
                Console.WriteLine("first value, second value & third value are same.");
                return null;
            }

        }
    }
}
