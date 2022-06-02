using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class GenericMaxValue<T> where T : IComparable
    {

        public T[] value;

        public GenericMaxValue(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(T[] values)
        {
            var sorted_value = Sort(values);
            return sorted_value[^1];

        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine($"Max Value is: {max}");
        }
    }
}
