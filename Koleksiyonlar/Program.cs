using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylar oluşturduğumuz sınırlarda kalır
            //string[] isimler = new string[] {"test","2-TEST","3-TEST","4-test" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "5TEST";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "TEST", "2TEST", "3TEST", "4TESTT" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("5TEST");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);

        }
    }
}