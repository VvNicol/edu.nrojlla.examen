using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.nrojlla.examen.Dtos
{
    /// <summary>
    /// <autor>nrojlla 040320204</autor>
    /// Base de datos de la agencia
    /// </summary>
    internal class AgenciaDto
    {
        long id;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 111111;
        DateTime fchaEntrega = DateTime.Now;

        public AgenciaDto()
        {
        }

        public AgenciaDto(long id, string nombreProducto, int cantidadProducto, DateTime fchaEntrega)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fchaEntrega = fchaEntrega;
        }

        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FchaEntrega { get => fchaEntrega; set => fchaEntrega = value; }
    }
}
