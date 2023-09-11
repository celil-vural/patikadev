class Program
{
    static void Main()
    {
        Console.WriteLine("Bir string ifade girin:");
        string input = Console.ReadLine() ?? "";

        if (!string.IsNullOrEmpty(input))
        {
            string[] words = input.Split(' ');
            while (words.Length > 0)
            {
                Console.Write(SwapFirstAndLastCharacters(words[0]) + " ");
                words = words.Skip(1).ToArray();
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Boş bir string ifade girmeyin.");
        }

        Console.ReadLine();
    }

    static string SwapFirstAndLastCharacters(string input)
    {
        if (input.Length <= 1)
        {
            return input;
        }

        char[] charArray = input.ToCharArray();

        char temp = charArray[0];
        charArray[0] = charArray[input.Length - 1];
        charArray[input.Length - 1] = temp;

        return new string(charArray);
    }
}
