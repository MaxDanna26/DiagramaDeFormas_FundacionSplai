using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    class Diagrama
    {
        int CantFormas;
        public List <Formas> formas = new List <Formas> ();
       
        public List<Formas> Formas { get => formas; set => formas = value; }

        public Diagrama(int cantFormas)
        {
            this.CantFormas = cantFormas;
            formas = new List<Formas> ();
        }

        public void RecorrerDiagrama ()
        {
            for (int i = 0; i < formas.Count; i++)
            {

            }
        }

    }
}
