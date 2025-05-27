using Ejercicio1.Models;
namespace Ejercicio1
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables.");
            Console.WriteLine("-1 Para Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarIniciarVariables()
        {
            Console.Clear();
            servicio = new Servicio();
            Console.WriteLine("Variables reiniciadas.");

            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un valor:");
            int v = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(v);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de números a ingresar:");
            int ingresos = Convert.ToInt32(Console.ReadLine());
            for(int contador = 0; contador < ingresos; contador++) {
                MostrarPantallaSolicitarNumero();
            }

        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine($"El valor mínimo ingresado es: {servicio.minimo}");
            Console.WriteLine($"El valor máximo ingresado es: {servicio.maximo}");

            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            if (servicio.contador > 0)
            {
                Console.WriteLine($"El promedio de los números ingresados es: {servicio.CalcularPromedio():f2}");
            }
            else
            {
                Console.WriteLine("No hubo ingreso de números.");
            }
            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();
            
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            if (servicio.contador > 0)
            {
                Console.WriteLine($"Cantidad de números ingresados: {servicio.contador}");
            }
            else
            {
                Console.WriteLine("No hubo ingreso de números.");
            }
            Console.WriteLine("Presione Enter para volver al menú principal.");
            Console.ReadKey();

        }


        static void Main(string[] args)
        {
            int opt = MostrarPantallaSolicitarOpcionMenu();

            while (opt != -1)
            {
                switch (opt)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariables();
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
