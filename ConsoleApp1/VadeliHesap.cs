
// Vadeli hesap sınıfı
class VadeliHesap : Hesap
{
    public decimal FaizOrani { get; set; }

    public void FaizEkle()
    {
        decimal faiz = Bakiye * FaizOrani / 100;
        Bakiye += faiz;
        Console.WriteLine($"Faiz eklendi. Yeni bakiye: {Bakiye} TL");
    }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye} TL");
    }

    public override void ParaCek(decimal miktar)
    {
        Console.WriteLine("Vadeli hesaptan doğrudan para çekilemez.");
    }
}
