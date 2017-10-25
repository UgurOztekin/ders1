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
            List<ogrenci> o = new List<ogrenci>() { new ogrenci
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
            }
            #endregion

            List<ogrenci> ogrenci1 = new List<ogrenci>();
           
            

        }



    }
}
