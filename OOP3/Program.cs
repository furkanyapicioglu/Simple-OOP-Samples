using System;
using System.Collections.Generic;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager,esnafKrediManager};

            foreach(var a in krediler)
            {
                basvuruManager.BasvuruYap(a, new List<ILoggerService> {
                    smsLoggerService,fileLoggerService,databaseLoggerService });

            }

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
