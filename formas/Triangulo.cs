using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    public class Triangulo : Poligono
    {
        public int ancho;
        public int ladoA;

        public override double Area()
        {
            int resultado = (ancho * ladoA) / 2;

            return resultado;
        }

        public override double Perimetro()
        {
            int resultado = ancho + (ladoA * 2);
            return resultado;
        }

        public Triangulo() : base(3)
        {
        }



        
    }
}
