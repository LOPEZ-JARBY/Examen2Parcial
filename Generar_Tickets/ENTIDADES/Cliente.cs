using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Identidad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EstaActivo { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string identidad, string nombreCliente, string telefono, string correo, string direccion, DateTime fechaNacimiento, bool estaActivo)
        {
            Id = id;
            NombreCliente = nombreCliente;
            Identidad = identidad;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            EstaActivo = estaActivo;
        }
    }
}
