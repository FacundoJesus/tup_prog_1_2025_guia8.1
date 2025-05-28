using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7.Models
{
    internal class Servicio
    {
        #region Atributos de la clase Program
        public int cantidad1;
        public int cantidad2;
        public int cantidad3;
        public int cantidad4;
        public int cantidad5;
        public int contadorDeTransacciones;
        public int numeroTransaccionMayor;
        public double montoTransaccionMayor;
        public double porcentajeCantidadRubro1;
        public double porcentajeCantidadRubro2;
        public double porcentajeCantidadRubro3;
        public double porcentajeCantidadRubro4;
        public double porcentajeCantidadRubro5;
        public double recaudacionTotal;
        public double mayorMonto;
        #endregion


        #region Métodos de proceso
        public void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            contadorDeTransacciones = 0;
            recaudacionTotal = 0;
            mayorMonto = 0;
        }
        public void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            recaudacionTotal += monto;
            //Asigno en la 1° iteracion al numero de transaccion con mayor monto;
            if (contadorDeTransacciones == 1 || monto > mayorMonto)
            {
                numeroTransaccionMayor = nroTransaccion;
                mayorMonto = monto;
            }
            switch (rubro)
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                case 2:
                    cantidad2 += cantidad;
                    break;
                case 3:
                    cantidad3 += cantidad;
                    break;
                case 4:
                    cantidad4 += cantidad;
                    break;
                case 5:
                    cantidad5 += cantidad;
                    break;
                default:
                    Console.WriteLine("Rubro no válido");
                    break;
            }
            if (rubro > 0 && rubro < 6)
            {
                contadorDeTransacciones++;
            }

        }
        public void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int cantidadTotal = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            if (contadorDeTransacciones > 0)
            {
                porcentajeCantidadRubro1 = (cantidad1 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro2 = (cantidad2 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro3 = (cantidad3 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro4 = (cantidad4 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro5 = (cantidad5 * 1.0 / cantidadTotal) * 100;
            }
            else
            {
                Console.WriteLine("No se han registrado transacciones!");
            }
        }
        #endregion
    }
}
