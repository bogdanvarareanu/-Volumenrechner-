using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Quader
    {
        private double Laenge = 0;
        private double Breite = 0;
        private double Hoehe1 = 0;
        private double VolQ = 0;


        public void set_Laenge(double l) { Laenge = l; }
        public void set_Hoehe1(double h1) { Hoehe1 = h1; }
        public void set_Breite(double b) { Breite = b; }
        public double get_Laenge() { return Laenge; }
        public double get_Hoehe1() { return Hoehe1; }
        public double get_Breite() { return Breite; }


        public double get_VolQ()
        {
            VolQ = Laenge * Breite * Hoehe1;
            return VolQ;
        }


    }
}
