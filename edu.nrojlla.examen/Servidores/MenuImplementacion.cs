using edu.nrojlla.examen.Dtos;

namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor>nrojlla 040320204</autor>
    /// Logica de los metodos del menu interfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        List<AgenciaDto> AgenciaLista = new List<AgenciaDto>();
        List<EmpleadoDto> EmpleadoLista = new List<EmpleadoDto>();

        public void MenuAgencia()
        {
            AgenciaInterfaz ai = new AgenciaImplementacion();

            int opcionSeleccionada = MenuPrincipalAgencia();

            switch (opcionSeleccionada)
            {
                case 0:       

                    break;
                case 1:
                    ai.MostrarVentasDia(EmpleadoLista);

                    break;

                case 2:
                    ai.NuevoPedidoProveedores(AgenciaLista);

                    break;

                default:

                    Console.WriteLine("La opcion no existe");
                    break;
            }
        }

        private int MenuPrincipalAgencia()
        {

            Console.WriteLine("------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Mostrar ventas del dia");
            Console.WriteLine("2. Nuevo pedido para los proveedores");

            int opcionMenuA = int.Parse(Console.ReadLine());

            return opcionMenuA;
                
        }

        public void MenuEmpleado()
        {
            EmpleadoInterfaz ei = new EmpleadoImplementacion();
            int opcionSeleccionada = MenuPrincipalEmpleado();
            switch (opcionSeleccionada)
            {
                case 0:

                    break;
                case 1:
                    ei.CalculoTotalVentasDiario(EmpleadoLista);

                    break;

                case 2:
                    ei.AñadirVenta(EmpleadoLista);

                    break;

                default:

                    Console.WriteLine("La opcion no existe");
                    break;
            }
        }

        private int MenuPrincipalEmpleado()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Menu Empleado");
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Calculo total ventas diario");
            Console.WriteLine("2. Añadir venta");

            int opcionMenuE = int.Parse(Console.ReadLine());

            return opcionMenuE;
        }

        public int MenuPrincipal()
        {
            Console.WriteLine("------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Menu de empleado");
            Console.WriteLine("2. Menu de agencia");

            int opcionMenuE = int.Parse(Console.ReadLine());

            return opcionMenuE;
        }
    }
}