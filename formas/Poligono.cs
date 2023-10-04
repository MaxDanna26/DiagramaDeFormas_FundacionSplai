using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    public abstract class Poligono : Formas
    {
        public int CantLados;
        public override abstract double Area();
        public override abstract double Perimetro();
        public Poligono(int CantLados)
        {
        }

        public int GetLados ()
        {
            return CantLados;
        }

    }
    public class Rectangulo : Poligono
    {
        public int ancho;
        public int largo;

        public override double Area()
        {
            int resultado = ancho * largo;

            return resultado;
        }

        public override double Perimetro()
        {
            int resultado = (ancho * 2) + (largo * 2);
            return resultado;
        }
        public Rectangulo(int ancho, int largo) : base(4)
        {
            this.ancho = ancho;
            this.largo = largo;
        }


    }

    public class Cuadrado : Rectangulo
    {
        public int lado;

        public Cuadrado(int lado) : base(lado,lado)
        {
            this.lado = lado;
        }
    }
}
