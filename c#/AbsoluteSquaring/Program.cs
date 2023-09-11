class Program
{
    static void Main()
    {
        Console.WriteLine("Sayıları girin (boşlukla ayrılmış):");
        string input = Console.ReadLine() ?? "";
        string[] inputArray = input.Split(' ');

        int[] numbers = ParseNumbers(inputArray);

        if (numbers.Length > 0)
        {
            Dictionary<string, int> result = CalculateResult(numbers);
            Console.WriteLine($"Sonuç:{result["sumOfDifferences"]} {result["sumOfSquares"]}");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. En az bir sayı girilmelidir.");
        }

        Console.ReadLine();
    }

    static int[] ParseNumbers(string[] inputArray)
    {
        return inputArray.Select(numStr =>
        {
            if (int.TryParse(numStr, out int num))
            {
                return num;
            }
            else
            {
                Console.WriteLine("Geçersiz sayı: " + numStr);
                return 0;
            }
        }).ToArray();
    }

    static Dictionary<string, int> CalculateResult(int[] numbers)
    {
        int sumOfDifferences = 0;
        int sumOfSquares = 0;
        foreach (int num in numbers)
        {
            int difference = 67 - num;

            if (difference > 0)
            {
                sumOfDifferences += difference;
            }
            else
            {
                sumOfSquares += difference * difference;
            }
        }
        Dictionary<string, int> result = new();
        result.Add("sumOfDifferences", sumOfDifferences);
        result.Add("sumOfSquares", sumOfSquares);
        return result;
    }
}
