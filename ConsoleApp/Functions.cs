/*
*  -------------------------------------------------
* <copyright file=" Functions " company="IPCA"/>
* <date> 5/24/2019 4:45:52 PM </date>
* <author> bruno </author>
* <email> a16970@alunos.ipca.pt </email>
* <desc>
*   
* </desc>
* -------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class Function
    {
        public const double g = 9.8;

        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static bool FormulaResolvente(double a, double b, double c, out double r1, out double r2)
        {
            r1 = 0;
            r2 = 0;
            double delta = Math.Pow(b,2) + (-4 * a * c);

            if (delta >= 0)
            {
                r1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                r2 = ((-b - Math.Sqrt(delta)) / (2 * a));
                return true;
            }

            return false;
        }

        public static double AlcanceMax(double y, double v, double ang)
        {
            double r1, r2, t;
            if (FormulaResolvente(-(g/2), v*Math.Sin(ConvertToRadians(ang)), y, out r1, out r2))
            {
                t = Math.Max(r1, r2);
                return v * Math.Cos(ConvertToRadians(ang)) * t;
            }
            return 0;
        }

        public static double AltMax(double y, double v, double ang)
        {
            return y + ((Math.Pow(v, 2) * Math.Pow(Math.Sin(ConvertToRadians(ang)), 2)) / (2 * g));
        }

        public static void CFormaTraj(double v, double ang, out double c1, out double c2)
        {
            c1 = Math.Tan(ConvertToRadians(ang));
            c2 = (g / (2 * Math.Pow(v, 2) * Math.Pow(Math.Cos(ConvertToRadians(ang)), 2)));
        }

        public static double AltX(double x, double y, double v, double ang)
        {
            double c1, c2;
            CFormaTraj(v, ang, out c1, out c2);
            return y + (c1 * x) - (c2 * Math.Pow(x, 2));
        }

        public static double VelX(double v, double ang)
        {
            return v * Math.Cos(ConvertToRadians(ang));
        }

        public static double VelY(double x, double v, double ang)
        {
            return v * Math.Sin(ConvertToRadians(ang)) + (-g * x / v * Math.Cos(ConvertToRadians(ang)));
        }

        public static double VelTotal(double x, double v, double ang)
        {
            return Math.Sqrt(Math.Pow(VelX(v, ang), 2)+ Math.Pow(VelY(x, v, ang), 2));
        }
    }
}
