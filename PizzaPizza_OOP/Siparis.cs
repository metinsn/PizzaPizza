using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPizza_OOP
{
    class Siparis
    {
        public Siparis()
        {
            Pizzalar = new List<Pizza>();
        }
        public int SiparisID { get; set; }
        public string MusteriName { get; set; }
        public List<Pizza> Pizzalar { get; set; }
        public double ToplamFiyat { get; set; }

        public override string ToString()
        {
            return SiparisID.ToString() + "\t\t" + ToplamFiyat;
        }
    }
}
