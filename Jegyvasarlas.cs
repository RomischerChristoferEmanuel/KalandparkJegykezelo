using System;
using System.Collections.Generic;
using System.Text;

namespace KalandparkJegykezelo
{
    public class Jegyvasarlas
    {
        public string LatogatoNev { get; set; }
        public int FelnottJegyek { get; set; }
        public int GyerekJegyek { get; set; }
    }
    public Jegyvasarlas(string sor)
        {
            string[] darabol = sor.Split(';');
            LatogatoNev = darabol[0];
            FelnottJegyek = int.Parse(darabol[1]);
            GyerekJegyek = int.Parse((darabol[2]));
        }
        public int FizetendoOsszeg()
        {
            return FelnottJegyek * 4000 + GyerekJegyek * 2500;
        }
        public override string ToString()
        {
            return $"{LatogatoNev}: {FelnottJegyek} felnőtt, {GyerekJegyek} gyerek jegy - Fizetendő: {FizetendoOsszeg()} Ft";
        }
    }
}
