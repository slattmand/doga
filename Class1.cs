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
        private double negyzetoldal, teglaoldal1, teglaoldal2, kerulet1, kerulet2, terulet1, terulet2;

        public NegyszogClass() { }

        public NegyszogClass(double a) { this.negyzetoldal = a; }

        public NegyszogClass(double a, double b) { this.teglaoldal1 = a; this.teglaoldal2 = b; }



        public void setOldal1(double a) { this.negyzetoldal = a; }

        public void setOldal2(double a, double b) { this.teglaoldal1 = a; this.teglaoldal2 = b; }


        public void SetTerulet()
        {
            this.terulet1 = Math.Pow(this.negyzetoldal, 2);
            this.terulet2 = this.teglaoldal1 * this.teglaoldal2;
        }

        public void SetKerulet()
        {
            this.kerulet1 = this.negyzetoldal * 4;
            this.kerulet2 = (this.teglaoldal1 + this.teglaoldal2) * 2;
        }

        public double getTerulet()
        {
            return this.terulet1;
            return this.terulet2;
        }

        public double getKerulet()
        {
            return this.kerulet1;
            return this.kerulet2;
        }

        public double getNegyzet() { return this.negyzetoldal; }

        public double getTegla() { return this.teglaoldal1; this.teglaoldal2; }

    }
}
