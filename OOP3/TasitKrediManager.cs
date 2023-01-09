namespace OOP3;

public class TasitKrediManager:IKrediManager
{
    public void Hesapla()
    {
        Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
    }

    public void BirseyYap()
    {
        throw new NotImplementedException();
    }
}