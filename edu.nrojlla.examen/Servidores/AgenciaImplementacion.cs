using edu.nrojlla.examen.Dtos;

namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor>nrojlla 040320204</autor>
    /// Logica de los metodos del agencia interfaz
    /// </summary>
    ///
    internal class AgenciaImplementacion : AgenciaInterfaz
    {
        public void MostrarVentasDia(List<EmpleadoDto> empleadoLista)
        {
            EmpleadoInterfaz ei = new EmpleadoImplementacion();

            Console.WriteLine("Ingrese fecha (formato dd-mm-yyyy) : ");
            DateTime entrega = Convert.ToDateTime(Console.ReadLine());
            string archivo = "ddMMyyyy.txt";
            StreamWriter logStreamWriter = new StreamWriter(archivo);

            
            foreach (EmpleadoDto empleado in empleadoLista)
            {
                if (empleado.FchaFinActividad.Equals(entrega))
                {   
                    Console.WriteLine("Se ha creado un archivo con la informacion");
                    DateTime fecha = DateTime.Now;
                    string nombre = Contenido(empleado);
                    string nombreFichero =  fecha.ToString();
                    
                   string rutaCompletaFichero = nombreFichero;

                   using (StreamWriter sw = new StreamWriter(rutaCompletaFichero))
                   {
                         
                        sw.Write(nombre);
                    }   
                }
            }
        }

        private string Contenido(EmpleadoDto empleadoLista)
        {
             EmpleadoDto contenidoEscrito = new EmpleadoDto();

             string contenido =
                    "……….\n" +
                    $"Venta numero : {contenidoEscrito.Id}\n" +
                    $"Euros: {contenidoEscrito.Valor}\n" +
                    $"Instante de la compra : {contenidoEscrito.FchaFinActividad}\n";

            return contenido;  
        }

        public void NuevoPedidoProveedores(List<AgenciaDto> agenciaLista)
        {
            bool isContinuar = true;
            do
            {
                long id = nuevoId(agenciaLista);
                Console.WriteLine("Ingrese nombre : ");
                string nombreProducto = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad : ");
                int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese fecha de entrega (formato dd-mm-yyyy) : ");
                DateTime entrega = Convert.ToDateTime(Console.ReadLine());

                AgenciaDto nuevoPedido= new AgenciaDto(id, nombreProducto, cantidadProducto, entrega);
                agenciaLista.Add(nuevoPedido);

                Console.WriteLine("¿Agregar otra venta? y/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == 'y')
                {
                    isContinuar = true;

                }
                else if (sn == 'n')
                {
                    isContinuar = false;
                }

            } while (isContinuar);

            foreach(AgenciaDto agencia in agenciaLista)
            {
                Console.WriteLine($"Producto: {agencia.NombreProducto} \n" +
                                  $"Cantidad: {agencia.CantidadProducto}\n" +
                                  $"Fecha entrega: {agencia.FchaEntrega.ToShortDateString()}\n");
            }

        }

        private long nuevoId(List<AgenciaDto> agenciaLista)
        {
            long idCalcular;
            if (agenciaLista.Count() > 0)
            {
                idCalcular = 1;
            }
            else
            {
                idCalcular = agenciaLista.Count() + 1;
            }
            return idCalcular;
        }
    }
}