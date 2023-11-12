namespace Oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLogger = new DatabaseLogger();
            ILoggerService fileLogger = new FileLogger();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLogger, fileLogger };

            basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}