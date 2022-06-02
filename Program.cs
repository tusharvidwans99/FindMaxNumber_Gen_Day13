namespace FindMaximumNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program where we Finding the largest number: ");
            MaxNumber maxNumber = new MaxNumber();
            //Console.WriteLine(maxNumber.MaxNumberIs(99, 100, 101));
            //Console.WriteLine(maxNumber.MaxNumberIs(99.5, 99.3, 34.3));
            //Console.WriteLine(maxNumber.MaxNumberIs("22","35","74"));

            int[] intArray = { 99, 100, 101, 543, 785 };
            GenericMaxValue<int> genericMaxValue = new GenericMaxValue<int>(intArray);
            genericMaxValue.PrintMaxValue();

            double[] doubles = { 99.5, 99.3, 34.3, 45.4, 666.8 };
            GenericMaxValue<double> genericMaxValue1 = new GenericMaxValue<double>(doubles);
            genericMaxValue1.PrintMaxValue();

            string[] stringArray = { "22", "35", "74", "557","433" };
            GenericMaxValue<string> genericMaxValue2 = new GenericMaxValue<string>(stringArray);
            genericMaxValue2.PrintMaxValue();
        }
    }
}