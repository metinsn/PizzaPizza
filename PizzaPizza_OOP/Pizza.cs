using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPizza_OOP
{
    class Pizza : BasePizza
    {
        public Pizza()
        {
            Malzemeler = new List<Malzeme>();
        }
        public string Boyut { get; set; }
        public bool KalinMi { get; set; }
        public List<Malzeme> Malzemeler { get; set; }
        public int Adet { get; set; }
        public double BoyutFiyat
        {
            get
            {
                if (Boyut == "Küçük")
                    return 1;

                else if (Boyut == "Orta")
                    return 1.5;

                else if (Boyut == "Büyük")
                    return 2;

                else if (Boyut == "Maxi")
                    return 3;
                else
                    return 0;
            }
        }
        public double Fiyat
        {
            get
            {
                if (Isim == "Klasik")
                    return Adet * BoyutFiyat * 10;

                else if (Isim == "Karışık")
                    return Adet * BoyutFiyat * 15;

                else if (Isim == "Akdeniz")
                    return Adet * BoyutFiyat * 20;

                else if (Boyut == "Karadeniz")
                    return Adet * BoyutFiyat * 25;

                else
                    return 0;
            }
        }
    }
}
