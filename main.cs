using System;

namespace MyApp
{
    public class Ogrenci
    {
        private int ogrenciId;
        private string ogrenciName;
        private string ogrenciSurname;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrenciId, string _ogrenciName, string _ogrenciSurname, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrenciId = _ogrenciId;
            ogrenciName = _ogrenciName;
            ogrenciSurname = _ogrenciSurname;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void ogrenciBilgileriniGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + ogrenciId);
            Console.WriteLine("Öğrenci Adı: " + ogrenciName);
            Console.WriteLine("Öğrenci Soyadı: " + ogrenciSurname);
            Console.WriteLine("Öğrenci 1.Vize Notu: " + vize1);
            Console.WriteLine("Öğrenci 2.Vize Notu: " + vize2);
            Console.WriteLine("Öğrenci Final Notu: " + final);
            Console.WriteLine("Öğrenci Okul İsmi: " + okulIsmi);
        }

        public double ogrenciNotuHesapla()
        {
            return vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
        }

        public string harfNotunuGetir()
        {
            double ortalama = ogrenciNotuHesapla();
            if (ortalama >= 90)
                return "AA";
            else if (ortalama >= 80)
                return "BA";
            else if (ortalama >= 70)
                return "BB";
            else if (ortalama >= 60)
                return "CB";
            else if (ortalama >= 50)
                return "CC";
            else
                return "FF"; // Assuming the lowest grade is FF for failing
        }

        public void OkulGetir()
        {
            Console.WriteLine("Öğrenci Okul İsmi: " + okulIsmi);
        }
    }
}

