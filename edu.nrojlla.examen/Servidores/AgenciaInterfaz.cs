using edu.nrojlla.examen.Dtos;

namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor>nrojlla 04022024</autor>+
    /// Biblioteca de metodos del agencia
    /// </summary>
    internal interface AgenciaInterfaz
    {
        /// <summary>
        /// Muestra las ventas del dia
        /// </summary>
        /// <param name="empleadoLista"></param>
        void MostrarVentasDia(List<EmpleadoDto> empleadoLista);
        /// <summary>
        /// Crea un pedido para los proveedores
        /// </summary>
        /// <param name="agenciaLista"></param>
        void NuevoPedidoProveedores(List<AgenciaDto> agenciaLista);
    }
}