class Program
{
    static Dictionary<string, decimal> accounts = new Dictionary<string, decimal>();
    static string currentUser = "";
    static string logFilePath = "TransactionLog.txt";

    static void Main()
    {
        InitializeAccounts();
        Console.WriteLine("ATM Uygulamasına Hoş Geldiniz!");

        while (true)
        {
            if (string.IsNullOrEmpty(currentUser))
            {
                Console.Write("Kullanıcı Adınızı Girin: ");
                currentUser = Console.ReadLine() ?? "";

                if (!accounts.ContainsKey(currentUser))
                {
                    Console.WriteLine("Kullanıcı bulunamadı. Lütfen geçerli bir kullanıcı adı girin.");
                    currentUser = "";
                }
            }
            else
            {
                ShowMenu();
                int selectedOption = GetSelectedOption();

                switch (selectedOption)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        Withdraw();
                        break;
                    case 4:
                        EndOfDayProcess();
                        break;
                    case 5:
                        currentUser = "";
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
                        break;
                }
            }
        }
    }

    static void InitializeAccounts()
    {
        accounts.Add("user1", 1000);
        accounts.Add("user2", 2000);
        accounts.Add("user3", 3000);
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nİşlem Menüsü:");
        Console.WriteLine("1. Bakiye Sorgulama");
        Console.WriteLine("2. Para Yatırma");
        Console.WriteLine("3. Para Çekme");
        Console.WriteLine("4. Gün Sonu İşlemleri");
        Console.WriteLine("5. Çıkış");
    }

    static int GetSelectedOption()
    {
        Console.Write("Lütfen bir işlem seçin: ");
        int selectedOption;

        if (int.TryParse(Console.ReadLine(), out selectedOption))
        {
            return selectedOption;
        }

        return -1;
    }

    static void CheckBalance()
    {
        decimal balance = accounts[currentUser];
        Console.WriteLine($"Bakiyeniz: {balance}$");
    }

    static void Deposit()
    {
        Console.Write("Yatırmak istediğiniz tutarı girin: ");
        decimal amount;

        if (decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
        {
            accounts[currentUser] += amount;
            Console.WriteLine($"{currentUser}, {amount}$ tutarında para yatırdı.");
        }
        else
        {
            Console.WriteLine("Geçersiz tutar. Lütfen pozitif bir sayı girin.");
        }
    }

    static void Withdraw()
    {
        Console.Write("Çekmek istediğiniz tutarı girin: ");
        decimal amount;

        if (decimal.TryParse(Console.ReadLine(), out amount) && amount > 0)
        {
            if (accounts[currentUser] >= amount)
            {
                accounts[currentUser] -= amount;
                Console.WriteLine($"{currentUser}, {amount} tutarında para çekti.");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz tutar. Lütfen pozitif bir sayı girin.");
        }
    }

    static void EndOfDayProcess()
    {
        WriteTransactionLog();
        WriteErrorLog();
        WriteEndOfDayFile();
        Console.WriteLine("Gün sonu işlemleri tamamlandı.");
        currentUser = "";
    }

    static void WriteTransactionLog()
    {
        string logMessage = $"{DateTime.Now}: {currentUser} EOD işlemi yaptı.";
        File.AppendAllText(Path.Combine("..", "..", "..", logFilePath), logMessage + Environment.NewLine);
    }

    static void WriteErrorLog()
    {
        // Hatalı giriş denemeleri veya fraud olabilecek işlemler burada loglanabilir.
        // Örnek: "Hatalı giriş denemesi: {DateTime.Now}: {currentUser}"
    }

    static void WriteEndOfDayFile()
    {
        try
        {
            string fileName = $"EOD_{DateTime.Now:ddMMyyyy}.txt";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "EOD");
            Directory.CreateDirectory(path);
            using (StreamWriter sw = File.CreateText(Path.Combine(path, fileName)))
            {
                sw.WriteLine("Gün sonu EOD");
            }
            Console.WriteLine("Dosya oluşturuldu: " + fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Dosya oluşturma hatası: " + ex.Message);
        }
    }
}
