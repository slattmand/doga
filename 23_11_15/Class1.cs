using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _23_11_15
{
    class NegyszogClass
    {
        private double oldal1, oldal2, kerulet, terulet;

        public NegyszogClass() { }

        public NegyszogClass(double a) { this.oldal1 = a; }

        public NegyszogClass(double a, double b) { this.oldal1 = a; this.oldal2 = b; }



        public void setOldal1(double a) { this.oldal1 = a; }

        public void setOldal2(double a, double b) { this.oldal1 = a; this.oldal2 = b; }


        public void SetTerulet()
        {
            this.terulet = this.oldal1 * this.oldal2;
            
        }

        public void SetKerulet()
        {
            this.kerulet = (this.oldal1 + this.oldal2)*2;
        }

        public double getTerulet()
        {
            return this.terulet;
        }

        public double getKerulet()
        {
            return this.kerulet;
        }

    }
}
