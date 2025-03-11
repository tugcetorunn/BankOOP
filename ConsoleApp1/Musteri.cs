
// Müşteri sınıfı
class Musteri
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public List<Hesap> Hesaplar { get; set; } = new List<Hesap>();
}
