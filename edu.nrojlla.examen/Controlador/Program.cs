using edu.nrojlla.examen.Servidores;

namespace edu.nrojlla.examen.Controlador
{
    /// <summary>
    /// <uto>nrojlla 04032024</uto>
    /// </summary>
    /// aplicacion principal
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// <uto>nrojlla 04032024</uto>
        /// </summary>
        /// logica de la aplicacion
        /// <param name="args"></param>


        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();

            int opcionSeleccionada;
            bool isCerrado = false;

            do
            {
                opcionSeleccionada = mi.MenuPrincipal();
                switch (opcionSeleccionada)
                {
                    case 0:
                        isCerrado = true;
                        Console.WriteLine("Cerrado");

                        break;
                    case 1:
                        mi.MenuEmpleado();

                        break;

                    case 2:
                        mi.MenuAgencia();

                        break;

                    default:

                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!isCerrado);

        }
    }
}
