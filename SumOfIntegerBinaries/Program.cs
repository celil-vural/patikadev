namespace SumOfIntegerBinaries
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Integer ikilileri girin (boşlukla ayrılmış):");
            string input = Console.ReadLine() ?? "";
            string[] inputArray = input.Split(' ');

            if (inputArray.Length % 2 == 0)
            {
                List<int> results = ProcessInputPairs(inputArray);
                Console.WriteLine(string.Join(" ", results));
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Çift sayıda integer girilmelidir.");
            }

            Console.ReadLine();
        }

        static List<int> ProcessInputPairs(string[] inputArray)
        {
            List<int> results = new List<int>();

            for (int i = 0; i < inputArray.Length; i += 2)
            {
                int num1 = int.Parse(inputArray[i]);
                int num2 = int.Parse(inputArray[i + 1]);

                if (num1 != num2)
                {
                    results.Add(num1 + num2);
                }
                else
                {
                    results.Add(num1 * num1);
                }
            }

            return results;
        }
    }

}
