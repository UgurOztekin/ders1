using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirdersler
{
    class Program
    {

        public class ogrenci
        {
            public string adi { get; set; }
            public string soyadi { get; set; }
        }

       public static void Main(string[] args)
        {
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
        }
    }
}
