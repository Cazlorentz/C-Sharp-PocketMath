using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Math
{
    class QESSOLVER
    {
        public static double Discriminant(double _a, double _b, double _c)
        {
            return _b * _b - 4 * _a * _c;
        }

        public static List<object> Solutions(double _a, double _b, double _c)
        { 
            List<object> sols = new List<object>();
            double D = Discriminant(_a, _b, _c);
            object x1 = null;
            object x2 = null;

            if (D < 0)
            {
                x1 = "---";
                x2 = "---";
                sols.Add(x1); sols.Add(x2);
            }
            else if (D >= 0)
            {
                x1 = Math.Round(
                    (-_b + Math.Sqrt(D)) / (2 * _a)
                    , 5);
                x2 = Math.Round(
                    (-_b - Math.Sqrt(D)) / (2 * _a)
                    , 5);
                if ((Double)x1 < (Double)x2)
                {
                    sols.Add(x1); sols.Add(x2);
                }
                else
                {
                    sols.Add(x2); sols.Add(x1);
                }
            }
            
            return sols;
            
            
        }

        public static List<double> Extrema(double _a, double _b, double _c)
        {
            List<double> extrema = new List<double>();
            double D = Discriminant(_a, _b, _c);
            double Tx = Math.Round(-_b / (2 * _a), 5);
            double Ty = Math.Round(-D / (4 * _a), 5);
            extrema.Add(Tx);
            extrema.Add(Ty);
            return extrema;
        }
    }
}
