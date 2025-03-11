
Banka banka = new Banka { Ad = "Örnek Bankası" };
Sube sube = new Sube { Ad = "Merkez Şube" };
banka.Subeler.Add(sube);

Musteri musteri = new Musteri { Ad = "Ali", Soyad = "Yılmaz" };
sube.Musteriler.Add(musteri);

Hesap vadesiz = new VadesizHesap { HesapNo = "123456", Bakiye = 5000 };
Hesap vadeli = new VadeliHesap { HesapNo = "654321", Bakiye = 10000, FaizOrani = 5 };

musteri.Hesaplar.Add(vadesiz);
musteri.Hesaplar.Add(vadeli);

Kart krediKartı = new Kart { KartNumarasi = "1111-2222-3333-4444", Limit = 10000 };

vadesiz.ParaCek(1000);
vadeli.ParaYatir(2000);
((VadeliHesap)vadeli).FaizEkle();

krediKartı.HarcamaYap(3000);
krediKartı.BorcOde(1000);
