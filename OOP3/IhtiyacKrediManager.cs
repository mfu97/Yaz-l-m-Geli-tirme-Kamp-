namespace OOP3;

public class IhtiyacKrediManager:IKrediManager
{
    public void Hesapla()
    {
        Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
    }

    public void BirseyYap()
    {
        throw new NotImplementedException();
    }
}