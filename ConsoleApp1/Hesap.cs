
// Soyut hesap sınıfı
abstract class Hesap
{
    public string HesapNo { get; set; }
    public decimal Bakiye { get; protected set; }

    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);
}
