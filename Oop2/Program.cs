namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "John";
            //musteri1.Soyadi = "Doe";
            //musteri1.Id = 1;
            //musteri1.TcNo="1111111111";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri3);
        }
    }
}