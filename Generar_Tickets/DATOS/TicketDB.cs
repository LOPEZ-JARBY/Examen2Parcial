using ENTIDADES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class TicketDB
    {

        string cadena = "server=localhost; user=root; database=proyectofacturacion; password=Pass.Zij4m2023;";
        
        public bool Guardar(Ticket ticket)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO Tickets VALUES ");
                sql.Append(" (@Fecha, @Usuario, @Cliente, @Precio, @Descuento,@SubTotal, @Total, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta); ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena)) ;

            }
            catch (Exception ex)
            {

            }
            return inserto;
        }


    }
}
