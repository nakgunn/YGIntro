using System;
using System.Collections.Generic;
// SOLID prensiplerini çalış.  - interface referans tutucudur.
// interface leri birbirinin alternatifi olan seçenekler  kredinin türlerine göre esaplama değişkenlik gösterir
// kim nerede hangi operasyonu cagırdı - loglama -> dosyada, veritabanında tutulabilir. sms, mail atılabilir.
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla(); 
            */

            ILoggerService databaseLoggerService = new DatabaseLogService();
            ILoggerService fileLoggerService = new FileLogService();

            

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            List<ILoggerService> loggers = new List<ILoggerService> {fileLoggerService, databaseLoggerService };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
