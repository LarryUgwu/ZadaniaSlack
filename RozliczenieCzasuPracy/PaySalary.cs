using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozliczenieCzasuPracy
{
    public class PaySalary
    {
        private string fname;
        private string lname;
        private double rate;
        
        public double wyplata;
        public double czasPracy = 10;

        public PaySalary(string fname, string lname, double rate)
        {
            this.fname = fname;
            this.lname = lname;
            this.rate = rate;

        }

        public double Wyplata()
        {
            if (czasPracy <= 8)
            {
                return czasPracy * rate;
            }

            else
            {
                return 8 * rate + (czasPracy - 8) * 2 * rate;
            }
        }

 
    }


}
