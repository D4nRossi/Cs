using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CriandoClasseRepresentarMelhor
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //funcao pra calcular a area
        public double Area()//nao tem entrada pq ja esta na class
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}

