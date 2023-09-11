namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms you want in the series: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> fibo = Fibonacci_Iterative(n);
            Console.WriteLine($"Average:{Average(fibo)}");
            Console.ReadKey();
        }
        public static decimal Average(List<int> fibo)
        {
            decimal sum = 0;
            foreach (int i in fibo)
            {
                sum += i;
            }
            return sum / fibo.Count;
        }
        public static List<int> Fibonacci_Iterative(int len)
        {
            int a = 1, b = 1, c = 0;
            List<int> fibo = new List<int> { 1, 1 };
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                a = b;
                b = c;
                fibo.Add(c);
            }
            return fibo;
        }
    }
}
