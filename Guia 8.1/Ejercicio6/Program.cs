using Ejercicio6.Models;

namespace Ejercicio6
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region Métodos para imprimir en pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine("---MENU---");
            Console.WriteLine("Bienvenido a la Encuesta");
            Console.WriteLine("1- Registrar opinión");
            Console.WriteLine("2- Procesar y mostrar resultados encuesta");
            Console.WriteLine("-1 Para salir");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;

        }
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();

            Console.WriteLine("Ingrese la opinión:\n0 - Positivo\n1 - Negativo\n2 - Indeciso\n-1 Para Salir");
            int opinion = Convert.ToInt32(Console.ReadLine());

            while (opinion != -1)
            {

                servicio.RegistrarOpinion(opinion);

                Console.Clear();
                Console.WriteLine("Ingrese la opinión:\n0 - Positivo\n1 - Negativo\n2 - Indeciso\n-1 Para Salir");
                opinion = Convert.ToInt32(Console.ReadLine());

            }


        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            servicio.ProcesarEncuesta();
            Console.WriteLine("\nPresione Enter para volver al Menú principal");
            Console.ReadKey();
        }
        #endregion

       
        #region Menú consola
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != -1)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
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

