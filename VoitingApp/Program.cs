class Program
{
    static Dictionary<string, int> categories = new Dictionary<string, int>();
    static Dictionary<string, int> userVotes = new Dictionary<string, int>();
    static string currentUser = "";

    static void Main()
    {
        InitializeCategories();
        Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");

        while (true)
        {
            if (string.IsNullOrEmpty(currentUser))
            {
                currentUser = GetUserInput("Kullanıcı Adınızı Girin: ");
                if (!userVotes.ContainsKey(currentUser))
                {
                    userVotes.Add(currentUser, 0);
                }
            }

            ShowCategories();
            int selectedCategoryIndex = GetSelectedCategoryIndex();

            if (selectedCategoryIndex == 4)
            {
                break;
            }

            Vote(selectedCategoryIndex);
        }

        ShowResults();
    }

    static void InitializeCategories()
    {
        categories.Add("Film Kategorileri", 0);
        categories.Add("Tech Stack Kategorileri", 0);
        categories.Add("Spor Kategorileri", 0);
    }

    static void ShowCategories()
    {
        Console.WriteLine("\nKategoriler:");
        int index = 1;

        foreach (var category in categories)
        {
            Console.WriteLine($"{index}. {category.Key} - Oy Sayısı: {category.Value}");
            index++;
        }

        Console.WriteLine($"{index}. Çıkış");
    }

    static int GetSelectedCategoryIndex()
    {
        int selectedCategoryIndex;
        bool isValid = int.TryParse(GetUserInput("Lütfen bir kategori seçin (Çıkış için 4): "), out selectedCategoryIndex);

        if ((!isValid || selectedCategoryIndex < 0 || selectedCategoryIndex > categories.Count) && selectedCategoryIndex != 4)
        {
            Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
            return GetSelectedCategoryIndex();
        }

        return selectedCategoryIndex;
    }

    static void Vote(int selectedCategoryIndex)
    {
        if (selectedCategoryIndex == 0)
        {
            return; // Çıkış
        }

        string selectedCategory = categories.ElementAt(selectedCategoryIndex - 1).Key;
        categories[selectedCategory]++;
        userVotes[currentUser]++;
        Console.WriteLine($"{currentUser}, \"{selectedCategory}\" kategorisine oy verdi.");
    }

    static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }

    static void ShowResults()
    {
        Console.WriteLine("\nSonuçlar:");

        foreach (var category in categories)
        {
            int totalVotes = userVotes.Values.Sum();
            double percentage = (category.Value * 100.0) / totalVotes;
            Console.WriteLine($"{category.Key}: Oy Sayısı: {category.Value}, Yüzdesel: %{percentage:F2}");
        }
    }
}
