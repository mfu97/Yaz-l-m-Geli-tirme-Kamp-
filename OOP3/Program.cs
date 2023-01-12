// See https://aka.ms/new-console-template for more information

using OOP3;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
TasitKrediManager tasitKrediManager = new TasitKrediManager();
KonutKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService()};

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers );

var krediler = new List<IKrediManager>(){ihtiyacKrediManager};
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


