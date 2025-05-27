using Ejercicio3.Models;

namespace Ejercicio3
{

    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("-1 Para Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            for (int i = 0; i < 3; i++) {
                Console.Clear();
                Console.WriteLine($"Ingrese el nombre del {i+1}º alumno:");
                string name = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota del {i + 1}º alumno:");
                int nota = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarNombreYNumeroLibreta(name, nota);
            }
            Console.WriteLine("\nPresione Enter para volver al Menú Principal.");
            Console.ReadKey();
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("---Lista Ordenada---");
            Console.WriteLine($"Nombre: {servicio.nombre0} , Nota: {servicio.numeroLibreta0}");
            Console.WriteLine($"Nombre: {servicio.nombre1} , Nota: {servicio.numeroLibreta1}");
            Console.WriteLine($"Nombre: {servicio.nombre2} , Nota: {servicio.numeroLibreta2}");
            Console.WriteLine("\nPresione Enter para volver al Menú Principal.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int opc = MostrarPantallaSolicitarOpcionMenu();
            while (opc != -1)
            {
                switch(opc) {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                    default:
                        opc = -1;
                        break;
                }
                if (opc != -1)
                {
                    opc = MostrarPantallaSolicitarOpcionMenu();
                }

            }
        }
    }
}
