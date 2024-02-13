using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
       
        public int Multiply()
        {
            int res;
            res = Fnum * Snum;
            return res;
        }
        public int Subtract()
        {
            int res;
            res = Fnum - Snum;
            return res;
        }
        public int Division()
        {
            int res;
            res = Fnum / Snum;
            return res;
        }
    }

}