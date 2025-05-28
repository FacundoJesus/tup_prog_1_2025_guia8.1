using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Servicio
    {
        #region Metodos del proceso
        public void DeterminarLosDiasDelMes(int mes, int año)
        {
            if (mes == 2)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine("29 días");
                }
                else
                {
                    Console.WriteLine("28 días");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("30 días");
            }
            else
            {
                Console.WriteLine("31 días");
            }
        }
        public bool DeterminarSiEsBisiesto(int año)
        {
            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 4 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
