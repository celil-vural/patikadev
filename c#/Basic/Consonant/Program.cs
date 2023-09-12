class Program
{
    static void Main()
    {
        Console.WriteLine("Bir string ifade girin:");
        string input = Console.ReadLine() ?? "";
        string[] words = input.Split(' ');
        while (words.Length > 0)
        {
            Console.Write(CheckConsecutiveVowels(words[0]) + " ");
            words = words.Skip(1).ToArray();
        }
        Console.ReadLine();
    }

    static bool CheckConsecutiveVowels(string input)
    {
        input = input.ToLower();
        for (int i = 0; i < input.Length - 1; i++)
        {
            char currentChar = input[i];
            char nextChar = input[i + 1];

            if (!IsVowel(currentChar) && !IsVowel(nextChar))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsVowel(char c)
    {
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        return Array.IndexOf(vowels, c) != -1;
    }
}