namespace edu.nrojlla.examen.Servidores
{
    /// <summary>
    /// <autor> nrojlla 04032024 </autor>
    /// 
    /// biblioteca de menus
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menu de agencia
        /// </summary>
        void MenuAgencia();
        /// <summary>
        /// Menu de empleado
        /// </summary>
        void MenuEmpleado();
        /// <summary>
        /// Menu principal de la aplicacion
        /// </summary>
        /// <returns></returns>
        int MenuPrincipal();
    }
}