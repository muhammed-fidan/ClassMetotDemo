using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme();
            musteriManager.MusteriListeleme();
            musteriManager.MusteriSilme();
        }

        class Musteri
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string CustomerLastName { get; set; }

        }

        class MusteriManager
        {
            public void MusteriEkleme()
            {
                Console.WriteLine("Müşteri Başarıyla Eklendi");
            }

            public void MusteriListeleme()
            {
                Console.WriteLine("Müşteriler Başarıyla Listelendi");
            }

            public void MusteriSilme()
            {
                Console.WriteLine("Müşteri Başarıyla Silindi");
            }
        }
    }
}
