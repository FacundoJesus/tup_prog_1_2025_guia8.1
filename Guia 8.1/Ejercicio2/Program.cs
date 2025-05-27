using Ejercicio2.Models;
namespace Ejercicio2
{

    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("1- Iniciar Monto a repartir");
            Console.WriteLine("2- Solicitar Edad Por niña");
            Console.WriteLine("3- Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("-1 Para Salir del programa.");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el Monto a repartir:");
            double montoRepartir = Convert.ToDouble(Console.ReadLine());
            servicio.RegistrarMontoARepartir(montoRepartir);
            Console.WriteLine("Monto Registrado. Presione Enter para volver al menú principal.");
            Console.ReadKey();

        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            for (int i = 0; i < 4; i++) {
                Console.Clear();
                Console.WriteLine($"Ingrese la edad de la {i + 1}º niña:");
                int edadNiña = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarEdad(edadNiña, i);
                Console.Clear();
            }
            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            
            Console.Clear();
            servicio.CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"Prc de Edad de la Niña 1: {servicio.porcentaje0:f2}%, Monto: {servicio.monto0:c2}");
            Console.WriteLine($"Prc de Edad de la Niña 2: {servicio.porcentaje1:f2}%, Monto: {servicio.monto1:c2}");
            Console.WriteLine($"Prc de Edad de la Niña 3: {servicio.porcentaje2:f2}%, Monto: {servicio.monto2:c2}");
            Console.WriteLine($"Prc de Edad de la Niña 4: {servicio.porcentaje3:f2}%, Monto: {servicio.monto3:c2}");
            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int opt = MostrarPantallaSolicitarOpcionMenu();
            while (opt != -1)
            {
                switch(opt) {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        opt = -1;
                        break;
                }
                if (opt != -1)
                {
                    opt = MostrarPantallaSolicitarOpcionMenu();
                }

            }
        }
    }
}
