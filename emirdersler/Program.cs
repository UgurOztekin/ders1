using emirdersler.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirdersler
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region ders1
           /* List<ogrenci> o = new List<ogrenci>() { new ogrenci
            {
                adi="Ali", soyadi="yılmaz"
            },
            { new ogrenci
            {
                adi="sas", soyadi="yıasdasdlmaz"
            }} };
            
            for (int i = 0; i < o.Count; i++)
            {
                Console.WriteLine(o[i].adi);
                Console.ReadKey();
            }
            foreach (var item in o)
            {
                Console.WriteLine(item);
            }*/
            #endregion

            List<ogrenci> ogrenciler = new List<ogrenci>();

            ogrenciler.Add(new ogrenci { adi = "uğur", soyadi = "öztekin", numarasi = 826 });
            ogrenciler.Add(new ogrenci { adi = "ali", soyadi = "yılmaz", numarasi = 506 });
            ogrenciler.Add(new ogrenci { adi = "can", soyadi = "tekin", numarasi = 302 });
            ogrenciler.Add(new ogrenci { adi = "kemal", soyadi = "aydın", numarasi = 450 });
            ogrenciler.Add(new ogrenci { adi = "serdar", soyadi = "kartal", numarasi = 358 });

            List<Dersler> dersListesi = new List<Dersler>()
            {
                new Dersler() {dersAdi ="Matematik", gecmePuani = 45 },
                new Dersler() {dersAdi ="Fizik", gecmePuani = 50 },
                new Dersler() {dersAdi ="Kimya", gecmePuani = 48 },
            };

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.adi+" "+ item.soyadi +" "+ item.numarasi + item.Dersleri);
            }

            Console.Read();

        }



    }
}
