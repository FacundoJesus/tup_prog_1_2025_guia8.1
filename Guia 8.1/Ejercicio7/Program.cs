using Ejercicio7.Models;

namespace Ejercicio7
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region Métodos de imprimir pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine("---MENU---");
            Console.WriteLine("1 - Ingresar un resumen de venta");
            Console.WriteLine("2 - Mostrar Número de transacción registrado con el mayor monto total");
            Console.WriteLine("3 - Mostrar porcentaje en cantidad de ventas por rubro");
            Console.WriteLine("4 - Mostrar recaudación por rubro y recaudación total.");
            Console.WriteLine("-1 Para SALIR del Programa");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;

        }
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();

            Console.WriteLine("Ingrese el N° DE VENTA: (-1 P/Salir)");
            int nVenta = Convert.ToInt32(Console.ReadLine());

            servicio.InicializarVariables();
            while (nVenta != -1)
            {
                Console.WriteLine("Ingrese el N° DE RUBRO: 1 / 2 / 3 / 4 / 5");
                int nRubro = Convert.ToInt32(Console.ReadLine());

                if (nRubro > 0 && nRubro < 6)
                {
                    Console.WriteLine("Ingrese la cantidad de productos vendidos:");
                    int cantProductos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el Monto total del rubro:");
                    double montoRubro = Convert.ToDouble(Console.ReadLine());
                    servicio.EvaluarTransaccionPuntoDeVenta(nVenta, nRubro, cantProductos, montoRubro);
                }
                else
                {
                    Console.WriteLine("N° de Rubro no válido");
                }

                Console.WriteLine("Ingrese el N° DE VENTA: (-1 P/Salir)");
                nVenta = Convert.ToInt32(Console.ReadLine());
            }
            servicio.CalcularPorcentajesCantidadVentasPorRubro();
        }
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            Console.Clear();

            Console.WriteLine($"Cantidad de productos vendidos del Rubro 1: {servicio.cantidad1} // Porcentaje en cantidad Rubro 1: {servicio.porcentajeCantidadRubro1:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 2: {servicio.cantidad2} // Porcentaje en cantidad Rubro 2: {servicio.porcentajeCantidadRubro2:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 3: {servicio.cantidad3} // Porcentaje en cantidad Rubro 3: {servicio.porcentajeCantidadRubro3:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 4: {servicio.cantidad4} // Porcentaje en cantidad Rubro 4: {servicio.porcentajeCantidadRubro4:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 5: {servicio.cantidad5} // Porcentaje en cantidad Rubro 5: {servicio.porcentajeCantidadRubro5:f2}%");

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();

            if (servicio.contadorDeTransacciones > 0)
            {
                Console.WriteLine($"N° de VENTA con Mayor Monto: {servicio.numeroTransaccionMayor}, Monto: {servicio.mayorMonto:c2}");
            }
            else
            {
                Console.WriteLine("No hubo ventas.");
            }

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();


            Console.WriteLine($"Recaudación Total: {servicio.recaudacionTotal:c2}");

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        #endregion

        #region Menu
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != -1)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
                    default:
                        opcion = -1;
                        break;
                }

                if (opcion != -1)
                {
                    opcion = MostrarPantallaSolicitarOpcionMenu();
                }

            }
        }
        #endregion
    }
}
