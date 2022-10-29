using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos2
{
    internal class Calculadora
    {

        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}


