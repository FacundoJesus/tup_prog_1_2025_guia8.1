using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Models
{
    internal class Servicio
    {
        #region Variables de la clase program
        static int indecisos;
        static int negativos;
        static int positivos;
        static int encuestados;
        static double porcentajeIndecisos;
        static double porcentajeNegativos;
        static double porcentajePositivos;
        #endregion

        #region Métodos de proceso
        public void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 0:
                    positivos++;
                    break;
                case 1:
                    negativos++;
                    break;
                case 2:
                    indecisos++;
                    break;
                default:
                    Console.WriteLine("Opinión no válida");
                    break;
            }
            encuestados = positivos + negativos + indecisos;
        }
        public void ProcesarEncuesta()
        {
            if (encuestados > 0)
            {
                porcentajeIndecisos = (indecisos * 1.0 / encuestados) * 100;
                porcentajeNegativos = (negativos * 1.0 / encuestados) * 100;
                porcentajePositivos = (positivos * 1.0 / encuestados) * 100;
                Console.WriteLine($"Porcentaje de Indecisos: {porcentajeIndecisos:f2}% / Cantidad de Indecisos: {indecisos}");
                Console.WriteLine($"Porcentaje de Negativos: {porcentajeNegativos:f2}% / Cantidad de Negativos: {negativos}");
                Console.WriteLine($"Porcentaje de Positivos: {porcentajePositivos:f2}% / Cantidad de Positivos: {positivos}");
                Console.WriteLine($"Cantidad de Encuestados: {encuestados}");
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
            }
        }
        #endregion
    }
}
