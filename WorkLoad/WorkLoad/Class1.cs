using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLoad
{
    class Force
    {
        public double f;
        public double L;
        public double L1;
        public double L2;
        public double L3;
        public double L4;
        public double L5;
        public double q1;
        //public double m;
        public double F()
        {
            return f * (L - L2);
        }
        public double Q()
        {
            return (q1 * L5) * ((L4 + L5 / 2) - L);
        }
        public double F1()
        {
            return f * ((L - L2) + (L1 - L));
        }
        public double Q1()
        {
            return (q1 * L5) * ((L4 + L5 / 2) - L1);
        }
    }
}
