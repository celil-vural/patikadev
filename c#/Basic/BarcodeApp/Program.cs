using System.Drawing;
using ZXing;
using ZXing.QrCode;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Barkod Üret");
        Console.WriteLine("2. Barkodu Oku");
        Console.Write("Seçiminizi yapın (1 veya 2): ");
        string choice = Console.ReadLine() ?? "";

        if (choice == "1")
        {
            Console.Write("Üreteceğiniz metni girin: ");
            string textToEncode = Console.ReadLine() ?? "";
            GenerateBarcode(textToEncode);
        }
        else if (choice == "2")
        {
            Console.Write("Okunacak barkod dosyasının yolunu girin:");
            string barcodeImagePath = Console.ReadLine() ?? "";
            string decodedText = DecodeBarcode(barcodeImagePath);
            Console.WriteLine("Okunan Barkod: " + decodedText);
        }
        else
        {
            Console.WriteLine("Geçersiz seçenek.");
        }

        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadKey();
    }

    static void GenerateBarcode(string textToEncode)
    {
        BarcodeWriter<Bitmap> barcodeWriter = new BarcodeWriter<Bitmap>();
        barcodeWriter.Format = BarcodeFormat.CODE_39;
        QrCodeEncodingOptions encodingOptions = new QrCodeEncodingOptions
        {
            DisableECI = true,
            CharacterSet = "UTF-8",
            Width = 300,
            Height = 300
        };
        barcodeWriter.Options = encodingOptions;

        Bitmap barcodeBitmap = barcodeWriter.Write(textToEncode);
        Console.Write("Barkodu kaydedeceğiniz dosyanın adını girin (örneğin: barcode.png): ");
        string barcodeFileName = Console.ReadLine() ?? "";
        barcodeBitmap.Save(barcodeFileName);
        Console.WriteLine("Barkod başarıyla üretildi ve kaydedildi.");
    }

    static string DecodeBarcode(string barcodeImagePath)
    {
        BarcodeReader barcodeReader = BarcodeReader();
        Result result = barcodeReader.Decode(new Bitmap(barcodeImagePath));
        return result?.Text;
    }
}
