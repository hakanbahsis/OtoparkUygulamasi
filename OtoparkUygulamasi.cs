using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkUygulamasi
{
    class OtoparkUygulamasi
    {
        private int aracSayisi = 0;
        private int toplamtutar = 0;
        public enum Tur
        {
            Otomobil,
            Kamyonet,
            Otobüs,
            Kamyon,
            GenelToplam
        }

        public void Calistir()
        {
            
            Console.WriteLine("Otopark Uygulamasına Hoşgeldiniz.");
            BasaDon:
            Console.WriteLine("1-Otomobil");
            Console.WriteLine("2-Kamyonet");
            Console.WriteLine("3-Otobüs");
            Console.WriteLine("4-Kamyon");
            Console.WriteLine("5-Genel Toplamı Gör");
            Console.WriteLine("Lütfen Araç Seçimi Yapnız.");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Süreyi Girin");
            int sure = Convert.ToInt32(Console.ReadLine());
            CikisYap((Tur)secim-1,sure);
            goto BasaDon;
        }

        void CikisYap(Tur tur,int saat)
        {
            int tutar=0;
            switch (tur)
            {
                case Tur.Otomobil:
                    tutar = 5 * saat;
                    break;
                case Tur.Kamyonet:
                    tutar = 10 * saat;
                    break;
                case Tur.Otobüs:
                    tutar = 30 * saat;
                    break;
                case Tur.Kamyon:
                    tutar = 35 * saat;
                    break;
                case Tur.GenelToplam:
                    Console.WriteLine($"Giriş Yapan Araç Sayısı : {aracSayisi} Toplam Kazanç : {toplamtutar}");
                    return;

            }
            aracSayisi++;
            toplamtutar += tutar;
            Console.WriteLine($"Araç türü : {tur}  Süre : {saat}  Tutar : {tutar}");
        }
    }
}
