using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Sec4
{
    internal class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

    }

    
}
