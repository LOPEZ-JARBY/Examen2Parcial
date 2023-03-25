using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Ticket
    {
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }

        public Ticket()
        {
        }

        public Ticket(DateTime fecha, string usuario, string cliente, decimal precio, decimal descuento, decimal impuesto, decimal total, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta)
        {
            Fecha = fecha;
            Usuario = usuario;
            Cliente = cliente;
            Precio = precio;
            Descuento = descuento;
            Impuesto = impuesto;
            Total = total;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
        }
    }
}
