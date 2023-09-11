namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bir string ifade girin: ");
            string input = Console.ReadLine() ?? "";
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine("Sonuç: " + reversed);
            Console.ReadLine();
        }
    }

}
