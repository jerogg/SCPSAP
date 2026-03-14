using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modelos
    {
        /// <summary>
        /// DTO usado para devolver datos de contribuyente junto con
        /// el nombre de la tarifa y la descripción del estado.
        /// </summary>
        public class ContribuyenteDto
        {
            public int IdContribuyente { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public DateTime FechaAlta { get; set; }
            public int IdEstado { get; set; }
            public string EstadoDescripcion { get; set; }
            public int? IdTarifa { get; set; }
            public Decimal Tarifa { get; set; }
            public string Email { get; set; }
            public DateTime? FechaUltimoAviso { get; set; }
            public DateTime? FechaLimitePago { get; set; }
            public int? DiasGracia { get; set; }
        }

    }
}
