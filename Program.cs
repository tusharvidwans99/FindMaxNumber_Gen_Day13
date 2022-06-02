namespace FindMaximumNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this program where we Finding the largest number: ");
            MaxNumber maxNumber = new MaxNumber();
            Console.WriteLine(maxNumber.MaxNumberIs(99, 100, 101));

        }
    }
}