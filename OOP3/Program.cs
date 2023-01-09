// See https://aka.ms/new-console-template for more information

using OOP3;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
TasitKrediManager tasitKrediManager = new TasitKrediManager();
KonutKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager);

var krediler = new List<IKrediManager>();

