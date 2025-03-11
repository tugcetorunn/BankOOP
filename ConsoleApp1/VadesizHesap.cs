
// Vadesiz hesap sınıfı
class VadesizHesap : Hesap
{
    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye} TL");
    }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }
}
