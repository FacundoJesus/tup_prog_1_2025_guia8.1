using Ejercicio4.Models;

namespace Ejercicio4
{
   
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("1 - Registrar los nombres de los dos jugadores.");
            Console.WriteLine("2 - Registrar los resultados de cada set de los jugadores.");
            Console.WriteLine("3 - Mostrar el ganador.");
            Console.WriteLine("-1 Para Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            
            Console.WriteLine($"Ingrese el nombre del 1º Jugador:");
            string jugador1 = Console.ReadLine();
            Console.WriteLine($"Ingrese el nombre del 2º Jugador:");
            string jugador2 = Console.ReadLine();
            servicio.RegistrarJugadores(jugador1, jugador2);
            Console.WriteLine("\nPresione Enter para volver al Menú Principal.");
            Console.ReadKey();

        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            for(int i = 0; i < 3; i++) {
                Console.Clear();
                Console.WriteLine($"Ingrese los Puntos del {i + 1}º Set del Jugador 1:");
                int ptos_setJ1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese los Puntos del {i + 1}º Set del Jugador 2:");
                int ptos_setJ2 = Convert.ToInt32(Console.ReadLine());
                servicio.RegistrarResultadosSet(ptos_setJ1, ptos_setJ2);
            }
            Console.WriteLine("\nPresione Enter para volver al Menú Principal.");
            Console.ReadKey();

        }
        static void MostrarPantallaGanador()
        {
            string ganadorJuego = servicio.DeterminarGanador();
            Console.Clear();
            Console.WriteLine($"Ganador del Juego: {ganadorJuego}");
            Console.WriteLine("\nPresione Enter para volver al Menú Principal.");
            Console.ReadKey();
        }

        #region MENU
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != -1) {
                switch(opcion) {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
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
