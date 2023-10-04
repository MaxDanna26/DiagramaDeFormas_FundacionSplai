using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido usuario");
            Console.WriteLine("Cuantas formas desea añadir a su diagrama ?");
            int CantFormas = int.Parse(Console.ReadLine());
            Diagrama diagrama = new Diagrama(CantFormas);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Este diagrama debe comenzar con un circulo, digame la medida del radio: ");
            double medidaR = double.Parse(Console.ReadLine());
            Circulo circuloInicial = new Circulo(medidaR);
            diagrama.Formas.Add(circuloInicial);

            int opcion = 0;
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Con que prefieres continuar ?");
                Console.WriteLine("1. Rectangulo. ");
                Console.WriteLine("2. Cuadrado condicional. ");
                Console.WriteLine("3. Circulo final. ");
                Console.WriteLine("4. Suma total de todas las areas. ");
                Console.WriteLine("5. Salir. ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("De que tamaño quieres la base de tu rectangulo? ");
                        int ancho = int.Parse(Console.ReadLine());
                        Console.WriteLine("De que tamaño quieres la altura? ");
                        int largo = int.Parse(Console.ReadLine());

                        Rectangulo rectangulo = new Rectangulo(ancho, largo);
                        diagrama.Formas.Add(rectangulo);
                        break;
                    case 2:
                        Console.WriteLine("De que tamaño quieres los lados de tu cuadrado? ");
                        int lado = int.Parse(Console.ReadLine());

                        Cuadrado cuadradoCondicional = new Cuadrado(lado);
                        diagrama.Formas.Add(cuadradoCondicional);
                        break;
                    case 3:
                        Console.WriteLine("De que tamaño quieres el radio de tu circulo?  ");
                        int r = int.Parse(Console.ReadLine());

                        Circulo circuloFin = new Circulo(r);
                        diagrama.Formas.Add(circuloFin);
                        break;
                    case 4:
                        double sumaAreas = 0;
                        for (int i = 0; i < diagrama.formas.Count; i++)
                        {
                            double resultado = diagrama.formas[i].Area();
                            sumaAreas = resultado + sumaAreas;
                        }
                        Console.WriteLine(sumaAreas);
                        break;
                    default:
                        break;


                }
            } while (opcion != 5);

            Console.WriteLine("Ha salido del bucle");

            Console.ReadKey();

        }
    }
}
