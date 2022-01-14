using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Zylinder
    {
        private double Radius = 0;
        private double Hoehe=0;
        private double VolZ = 0;



        public void set_Radius(double r) { Radius = r; }
        public void set_Hoehe(double h) { Hoehe = h; }

        public double get_Radius () { return Radius; }
        public double get_Hoehe() { return Hoehe; }


        public double get_VolZ()
        {
            VolZ = Radius*Radius * 3.14 * Hoehe;
            return VolZ;
        }


    }
}
