using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        public int edad0;
        public int edad1;
        public int edad2;
        public int edad3;
        public double monto;
        public double monto0;
        public double monto1;
        public double monto2;
        public double monto3;
        public double porcentaje0;
        public double porcentaje1;
        public double porcentaje2;
        public double porcentaje3;

        public void RegistrarMontoARepartir(double m)
        {
            monto = m;
        }
        public void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0:
                    edad0 = edad;
                    break;
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
            }

        }
        public void CalcularMontosYPorcentajesARepartir()
        {

            int sumaEdades = edad0 + edad1 + edad2 + edad3;

            porcentaje0 = (edad0 * 1.0 / sumaEdades) * 100;
            porcentaje1 = (edad1 * 1.0 / sumaEdades) * 100;
            porcentaje2 = (edad2 * 1.0 / sumaEdades) * 100;
            porcentaje3 = (edad3 * 1.0 / sumaEdades) * 100;

            monto0 = (porcentaje0 * monto) / 100;
            monto1 = (porcentaje1 * monto) / 100;
            monto2 = (porcentaje2 * monto) / 100;
            monto3 = (porcentaje3 * monto) / 100;

        }
    }
}
