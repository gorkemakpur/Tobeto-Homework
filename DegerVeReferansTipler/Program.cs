namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 50, 60, 70 };
            sayilar1 = sayilar2;
            sayilar2[0] = 30000;

            Console.WriteLine(sayilar1[0]);

        }
    }
}