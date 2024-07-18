using MyApp;
using System;

namespace ConsoleApp8
{
    class Class1
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(133, "Emre", "Ağan", 96, 94, 100, "İstinye Üniversitesi");
            Console.WriteLine("Uygulamaya Hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz");
            islemleriGoster();
            bool kontrol = true;
            while (kontrol)
            {
                string islem = Console.ReadLine();
                switch (islem)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriniGoster();
                        break;
                    case "2":
                        Console.WriteLine("Öğrencinin Ortalaması: " + ogrenci1.ogrenciNotuHesapla());
                        break;
                    case "3":
                        Console.WriteLine("Öğrencinin Harf Notu ve Geçip Kalma Durumu: " + ogrenci1.harfNotunuGetir());
                        break;
                    case "4":
                        ogrenci1.OkulGetir();
                        break;
                    case "5":
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
        static void islemleriGoster()
        {
            Console.WriteLine("1. Öğrenci Bilgilerini Göster");
            Console.WriteLine("2. Öğrencinin Ortalamasını Göster");
            Console.WriteLine("3. Öğrencinin Harf Notunu ve Geçip Kalma Durumunu Göster");
            Console.WriteLine("4. Öğrencinin Okulunu Göster");
            Console.WriteLine("5. Çıkış Yap");
        }
    }
}


