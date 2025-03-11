
// Kart sınıfı
class Kart
{
    public string KartNumarasi { get; set; }
    public decimal Limit { get; set; }
    public decimal Borc { get; private set; }

    public void HarcamaYap(decimal miktar)
    {
        if (Borc + miktar <= Limit)
        {
            Borc += miktar;
            Console.WriteLine($"{miktar} TL harcama yapıldı. Kalan limit: {Limit - Borc} TL");
        }
        else
        {
            Console.WriteLine("Limit yetersiz!");
        }
    }

    public void BorcOde(decimal miktar)
    {
        if (miktar <= Borc)
        {
            Borc -= miktar;
            Console.WriteLine($"{miktar} TL borç ödendi. Kalan borç: {Borc} TL");
        }
        else
        {
            Console.WriteLine("Borcunuzdan fazla ödeme yapamazsınız!");
        }
    }
}
