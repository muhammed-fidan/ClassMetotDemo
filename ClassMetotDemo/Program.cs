using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri MusteriBilgileri1 = new Musteri();
            MusteriBilgileri1.MusteriAdi = "Engin";
            MusteriBilgileri1.MusteriSoyad = "Demiroğ";
            MusteriBilgileri1.MusteriTelNo = "05552223355";
            MusteriBilgileri1.Id = 101;

            Musteri MusteriBilgileri2 = new Musteri();
            MusteriBilgileri2.MusteriAdi = "Muhammed";
            MusteriBilgileri2.MusteriSoyad = "Fidan";
            MusteriBilgileri2.MusteriTelNo = "05551112225";
            MusteriBilgileri2.Id = 102;

            Musteri MusteriBilgileri3 = new Musteri();
            MusteriBilgileri3.MusteriAdi = "Rüzgar";
            MusteriBilgileri3.MusteriSoyad = "Mertoğlu";
            MusteriBilgileri3.MusteriTelNo = "05556667799";
            MusteriBilgileri3.Id = 103;


            //EKLENECEK MÜŞTERİ BİLGİLERİ.
            Musteri MusteriEklenen = new Musteri();


            //MÜŞTERİ EKLEME KODUM SATIR
            MusteriManager Add = new MusteriManager();
            Add.MusteriEkle(MusteriEklenen);



            //MÜŞTERİLERİ LİSTELEME
            MusteriManager list = new MusteriManager();
            list.MusteriListeleme(MusteriBilgileri1, MusteriBilgileri2, MusteriBilgileri3, MusteriEklenen);


            //MÜŞTERİ SİLME KODUM SATIR
            MusteriManager Delete = new MusteriManager();
            Delete.MusteriSilme(MusteriBilgileri3);

            //MÜŞTERİ SİLİNDİKTEN SONRA LİSTELEME
            list.MusteriListeleme(MusteriBilgileri1, MusteriBilgileri2, MusteriEklenen);



        }
       
    }
}



