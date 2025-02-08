namespace FirstChapterFirstMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Arka planı siyah yap
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Clear(); // Değişikliği uygulamak için ekranı temizle
            //Console.WriteLine("Hello, World!");

            //// Metni yeşil yap
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.Write("");
            //string input = Console.ReadLine(); // Kullanıcıdan veri al

            //// Girilen veriyi ekrana yeşil yazdır
            //Console.WriteLine(input);

            //// Programı kapatmadan önce beklet
            //Console.WriteLine("\ngörüşürüz...");
            //Console.ReadKey();

            //-------------------------------------------------------------


            //açılan konsolun boyutlarını bir telefon ekranı boyutuna nasıl çekerim? bir de bunun ekran kaydını nasıl alırım eşzamanlı? -chatGpt

            //new code

            // Konsol pencere boyutunu belirle (genişlik, yükseklik)
            Console.SetWindowSize(30, 15);

            // Arka planı siyah, metni yeşil yap
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("Hello World");
            Console.Write("");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
