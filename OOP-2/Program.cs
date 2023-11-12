namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Metotlar");

            //instance 
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 14);
            sepetManager.Ekle2("Elma", "Kırmızı", 17);
            sepetManager.Ekle2("Karpuz", "Yeşil Siyah", 22);
        }
    }
}