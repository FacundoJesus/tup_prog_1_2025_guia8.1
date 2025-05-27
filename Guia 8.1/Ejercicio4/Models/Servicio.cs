using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Servicio
    {
        private string jugador1;
        private string jugador2;
        private int setGanados1;
        private int setGanados2;

        public void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        public void RegistrarResultadosSet(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else
            {
                setGanados2++;
            }
        }
        public string DeterminarGanador()
        {
            string ganador = "";
            if (setGanados1 > setGanados2)
            {
                ganador = jugador1;
            }
            else
            {
                ganador = jugador1;
            }
            return ganador;
        }

    }
}
