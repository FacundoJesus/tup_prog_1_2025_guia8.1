using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Servicio
    {
        public string nombre0;
        public string nombre1;
        public string nombre2;

        public int numeroLibreta0;
        public int numeroLibreta1;
        public int numeroLibreta2;
        private int orden = 0;

        public void RegistrarNombreYNumeroLibreta(string nombre, int nroLibreta)
        {
            switch (orden)
            {
                case 0:
                    nombre0 = nombre;
                    numeroLibreta0 = nroLibreta;
                    break;
                case 1:
                    if (nroLibreta < numeroLibreta0)
                    {
                        nombre1 = nombre0;
                        numeroLibreta1 = numeroLibreta0;

                        nombre0 = nombre;
                        numeroLibreta0 = nroLibreta;
                    }
                    else
                    {
                        nombre1 = nombre;
                        numeroLibreta1 = nroLibreta;
                    }
                    break;
                case 2:
                    if (nroLibreta < numeroLibreta0)
                    {
                        nombre2 = nombre1;
                        numeroLibreta2 = numeroLibreta1;

                        nombre1 = nombre0;
                        numeroLibreta1 = numeroLibreta0;

                        nombre0 = nombre;
                        numeroLibreta0 = nroLibreta;
                    }
                    else
                    if (nroLibreta < numeroLibreta1)
                    {
                        nombre2 = nombre1;
                        numeroLibreta2 = numeroLibreta1;

                        nombre1 = nombre;
                        numeroLibreta1 = nroLibreta;
                    }
                    else
                    {
                        nombre2 = nombre;
                        numeroLibreta2 = nroLibreta;
                    }
                    break;
            }
            orden++;
        }
    }
}
