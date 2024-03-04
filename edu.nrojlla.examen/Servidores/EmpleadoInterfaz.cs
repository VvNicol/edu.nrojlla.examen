using edu.nrojlla.examen.Dtos;

namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor>nrojlla 04022024</autor>+
    /// Biblioteca de metodos del empleado
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Añade ventas
        /// </summary>
        /// <param name="empleadoLista"></param>
        void AñadirVenta(List<EmpleadoDto> empleadoLista);
        /// <summary>
        /// Calcula la venta diaria
        /// </summary>
        /// <param name="empleadoLista"></param>
        void CalculoTotalVentasDiario(List<Dtos.EmpleadoDto> empleadoLista);
    }
}