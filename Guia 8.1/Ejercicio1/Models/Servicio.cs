using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        private int acumulador;
        public int contador;
        public int maximo;
        public int minimo;

        public Servicio()
        {
            contador = 0;
            acumulador = 0;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio = (acumulador * 1.0) / contador;
            }
            return promedio;

        }
        public void RegistrarValor(int valor)
        {
            contador++;
            acumulador += valor;

            if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }
            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }
    }
}
