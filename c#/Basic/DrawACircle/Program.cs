class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double r;
        if (double.TryParse(Console.ReadLine(), out r) && r > 0)
        {
            DrawACircle(r);
        }
        else
        {
            Console.WriteLine("Invalid login. Please enter a positive number.");
        }

        Console.ReadLine();
    }

    private static void DrawACircle(double r)
    {
        int R = (int)(r * 2);
        for (int i = 0; i <= R; i++)
        {
            for (int j = 0; j <= R; j++)
            {
                double uzaklikMerkez = Math.Sqrt(Math.Pow(i - r, 2) + Math.Pow(j - r, 2));
                if (Math.Abs(uzaklikMerkez - r) < 0.5)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
