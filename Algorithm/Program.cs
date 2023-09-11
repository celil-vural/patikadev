namespace Algorithm
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bir string ifade ve bir indeks (virgülle ayrılmış) girin: ");
            string input = Console.ReadLine() ?? "";
            string[] parts = input.Split(',');
            if (parts.Length == 2)
            {
                string text = parts[0].Trim();
                if (int.TryParse(parts[1].Trim(), out int index) && index >= 0 && index < text.Length)
                {
                    string result = text.Remove(index, 1);
                    Console.WriteLine("Sonuç: " + result);
                }
                else
                {
                    Console.WriteLine("Geçersiz indeks. Lütfen pozitif bir tam sayı indeksi girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Bir string ifade ve bir indeks (virgülle ayrılmış) girin.");
            }

            Console.ReadLine();
        }
    }

}
