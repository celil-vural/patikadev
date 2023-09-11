namespace GeometricalShapes
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Lütfen hesaplamak istediğiniz geometrik şekli seçin:");
            Console.WriteLine("1. Kare");
            Console.WriteLine("2. Daire");
            Console.WriteLine("3. Üçgen");
            Console.WriteLine("4. Dikdörtgen");
            Console.Write("Seçiminizi yapın (1, 2, 3 veya 4): ");

            string secim = Console.ReadLine() ?? "0";

            switch (secim)
            {
                case "1":
                    KareHesapla();
                    break;
                case "2":
                    DaireHesapla();
                    break;
                case "3":
                    UcgenHesapla();
                    break;
                case "4":
                    DikdortgenHesapla();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }

            Console.ReadLine();
        }

        static void KareHesapla()
        {
            Console.Write("Karenin kenar uzunluğunu girin: ");
            if (double.TryParse(Console.ReadLine(), out double kenar) && kenar > 0)
            {
                Console.WriteLine("Hesaplamak istediğiniz boyutu seçin:");
                GetSelectionPrint();
                string boyutSecim = Console.ReadLine() ?? "0";
                switch (boyutSecim)
                {
                    case "1":
                        double cevre = 4 * kenar;
                        Console.WriteLine("Karenin Çevresi: " + cevre);
                        break;
                    case "2":
                        double alan = kenar * kenar;
                        Console.WriteLine("Karenin Alanı: " + alan);
                        break;
                    case "3":
                        double hacim = kenar * kenar * kenar;
                        Console.WriteLine("Karenin Hacmi: " + hacim);
                        break;
                    default:
                        Console.WriteLine("Geçersiz boyut seçimi.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz kenar uzunluğu. Pozitif bir sayı girin.");
            }
        }

        private static void GetSelectionPrint()
        {
            Console.WriteLine("1. Çevre");
            Console.WriteLine("2. Alan");
            Console.WriteLine("3. Hacim");
            Console.Write("Seçiminizi yapın:");
        }

        static void DaireHesapla()
        {
            Console.Write("Dairenin yarıçapını girin: ");
            if (double.TryParse(Console.ReadLine(), out double yaricap) && yaricap > 0)
            {
                GetSelectionPrint();
                string boyutSecim = Console.ReadLine() ?? "0";
                switch (boyutSecim)
                {
                    case "1":
                        double cevre = 2 * Math.PI * yaricap;
                        Console.WriteLine("Dairenin Çevresi: " + cevre);
                        break;
                    case "2":
                        double alan = Math.PI * yaricap * yaricap;
                        Console.WriteLine("Dairenin Alanı: " + alan);
                        break;
                    case "3":
                        double hacim = 4 / 3 * Math.PI * yaricap * yaricap * yaricap;
                        Console.WriteLine("Dairenin Hacmi: " + hacim);
                        break;
                    default:
                        Console.WriteLine("Geçersiz boyut seçimi.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz yarıçap. Pozitif bir sayı girin.");
            }
        }

        static void UcgenHesapla()
        {
            Console.Write("Üçgenin taban uzunluğunu girin: ");
            if (double.TryParse(Console.ReadLine(), out double taban) && taban > 0)
            {
                Console.Write("Üçgenin yüksekliğini girin: ");
                if (double.TryParse(Console.ReadLine(), out double yukseklik) && yukseklik > 0)
                {

                    GetSelectionPrint();
                    string boyutSecim = Console.ReadLine() ?? "0";
                    switch (boyutSecim)
                    {
                        case "1":
                            Console.WriteLine("Üçgenin çevresi hesaplanamaz.");
                            break;
                        case "2":
                            double alan = 0.5 * taban * yukseklik;
                            Console.WriteLine($"Üçgenin Alanı: {alan}");
                            break;
                        case "3":
                            Console.WriteLine("Üçgenin hacmi hesaplanamaz.");
                            break;
                        default:
                            Console.WriteLine("Geçersiz boyut seçimi.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz yükseklik. Pozitif bir sayı girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz taban uzunluğu. Pozitif bir sayı girin.");
            }
        }
    }

}
