using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emirdersler.models
{
    public class ogrenci
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int numarasi { get; set; }
        public List<Dersler> Dersleri { get; set; }
    }
}
