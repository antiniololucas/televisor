using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_antiñolo
{
    internal class Televisor
    {

        public Televisor()
        {
            crearImagenes();
        }

        public bool validacion   = false;
        public int volumen       = 0;
        public int canal         = 1;
        public string[] imagenes = new string[8];
        public bool validationMute = false;


        public void crearImagenes()
        {

            for (int i = 0; i <= 7; i++)
            {
                imagenes[i] = $"C:/Todo/2 AÑO/POO/Televisor-antiñolo/Resources/{i}.jpg";
            }
        }

    }
}
