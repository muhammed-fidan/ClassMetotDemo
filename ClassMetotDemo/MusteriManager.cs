using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("************EKLENEN MÜŞTERİLER********");
            musteri.Id = 104;
            musteri.MusteriAdi = "Rıza";
            musteri.MusteriSoyad = "Aksoy";
            musteri.MusteriTelNo = "05552133344";

            Console.WriteLine(musteri.Id + " : " + musteri.MusteriAdi + " " + musteri.MusteriSoyad + " : " + musteri.MusteriTelNo + Environment.NewLine + "Müşteri Başarıyla Eklendi!"+Environment.NewLine);
        }

        public void MusteriSilme(Musteri musteri2)
        {
            Console.WriteLine("____________SİLİNEN MÜŞTERİ BİLGİLERİ__________");
            Console.WriteLine(Environment.NewLine  + musteri2.Id + " : " + musteri2.MusteriAdi + " : " + musteri2.MusteriSoyad + " : " + musteri2.MusteriTelNo);
            Console.WriteLine("Müşteri Başarıyla Silindi!" + Environment.NewLine);
        }

        public void MusteriListeleme(params Musteri[] musterilers)
        {
            Console.WriteLine("--------KAYITLI MÜŞTERİ LİSTESİ------------");
            foreach (Musteri Listele in musterilers)
            {
                Console.WriteLine(Listele.Id + " : " + Listele.MusteriAdi + " " + Listele.MusteriSoyad + " : " + Listele.MusteriTelNo + Environment.NewLine);  
            }
            
        }
    }
    
}
