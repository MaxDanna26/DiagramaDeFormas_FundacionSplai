using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    class Circulo : Formas
    {
        public double r;
        public double pi = 3.14;

        public Circulo(double r) 
        {
            this.r = r;
        }

        public override double Area()
        {
            double resultado = pi * (r * r);
            return resultado;
        }

        public override double Perimetro()
        {
            double diametro = r * 2;
            double resultado = pi * diametro;
            return resultado;
        }
    }
}
