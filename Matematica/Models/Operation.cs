using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matematica.Models
{
    public class Operation
    {
        public double val1 { get; set; }
        public double val2 { get; set; }
        public string op { get; set; }
        public double result { get; set; }

        public Operation(double v1, double v2, string oper)
        {
            val1 = v1;
            val2 = v2;
            op = oper;
            result = 0;
        }

        public double operate()
        {
            if(op.Equals("p"))
            {
                result = val1 + val2;
            }
            else if(op.Equals("m"))
            {
                result = val1 - val2;
            }
            else if (op.Equals("t"))
            {
                result = val1 * val2;
            }
            else if (op.Equals("d"))
            {
                result = val1 / val2;
            }

            return result;

        }

    }
}