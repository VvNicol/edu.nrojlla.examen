using edu.nrojlla.examen.Dtos;

namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor>nrojlla 040320204</autor>
    /// Logica de los metodos del empleado interfaz
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void AñadirVenta(List<EmpleadoDto> empleadoLista)
        {
            bool isContinuar = true;
            do{
                long id = nuevoId(empleadoLista);
                Console.WriteLine("Ingrese venta (ej: 1,00) : ");
                decimal coste = Convert.ToDecimal(Console.ReadLine());
                DateTime instante = DateTime.Now;
                String horaCompra = instante.ToString("HH:mm:ss");
                
                EmpleadoDto nuevoVenta = new EmpleadoDto(id, coste, instante, horaCompra);
                empleadoLista.Add(nuevoVenta);
                Console.WriteLine("¿Agregar otra venta? y/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if(sn == 'y')
                {
                    isContinuar = true;

                }else if (sn == 'n')
                {
                    isContinuar = false;
                }

            } while (isContinuar);

        }

        private long nuevoId(List<EmpleadoDto> empleadoLista)
        {
            long idCalcular;
            if(empleadoLista.Count() > 0)
            {
                idCalcular = 1;
            } else
            {
                idCalcular = empleadoLista.Count() + 1;
            }
            return idCalcular;
        }

        public void CalculoTotalVentasDiario(List<EmpleadoDto> empleadoLista)
        {

            Console.WriteLine("Ingrese una fecha (formato dd-mm-yyy): ");
            DateTime fcha = Convert.ToDateTime(Console.ReadLine());

            decimal totalVentasDiaro = 0;
            TimeSpan diferenciaDeTiempo = TimeSpan.Zero;

            foreach (EmpleadoDto venta in empleadoLista)
            {

                if (venta.FchaFinActividad.Date == fcha.Date)
                {

                    decimal numero = venta.Valor;
                    totalVentasDiaro += numero;
                    diferenciaDeTiempo = TimeSpan.Parse(venta.HoraCompleta) - diferenciaDeTiempo;

                }
            }

            Console.WriteLine($"Total venta {totalVentasDiaro} euros ");
            Console.WriteLine($"Tiempo transcurrido: {diferenciaDeTiempo.Hours} horas {diferenciaDeTiempo.Minutes} minutos y {diferenciaDeTiempo.Seconds} segundos");


        }
    }
}