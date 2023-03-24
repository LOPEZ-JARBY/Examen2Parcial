using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public DateTime Fecha { get; set; }

        public Usuario()
        {
        }
        public Usuario(string codigoUsuario, string nombre, string password, string correo, string rol, DateTime fecha)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Password = password;
            Correo = correo;
            Rol = rol;
            Fecha = fecha;
        }
    }
}
