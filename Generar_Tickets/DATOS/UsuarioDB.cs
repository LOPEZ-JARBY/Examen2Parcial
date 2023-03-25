using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MySql.Data.MySqlClient;

namespace DATOS
{
    public class UsuarioDB
    {

        string cadena = "server=localhost; user=root; database=proyectofacturacion; password=Pass.Zij4m2023;";
        public Usuario Autenticar(Login login)
        {
            Usuario user = null;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Usuario WHERE CodigoUsuario = @CodigoUsuario  AND Contraseña = @Contraseña;");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 80).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 50).Value = login.Contraseña;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.CodigoUsuario = dr["Contraseña"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            user.LugarMantenimiento = dr["LugarMantenimiento"].ToString();

                        }
                    }

                }

            }
            catch (System.Exception ex)
            {

            }
            return user;
        }

        public bool Insertar(Usuario user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO Usuario VALUES ");
                sql.Append(" (@CodigoUsuario, @Contraseña, @Nombre, @Correo, @Rol, @Fecha, @LugarMantenimiento); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 80).Value = user.CodigoUsuario;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 50).Value = user.Contraseña;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = user.Nombre;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 50).Value = user.Correo;
                        comando.Parameters.Add("@Rol", MySqlDbType.VarChar, 50).Value = user.Rol;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = user.Fecha;
                        comando.Parameters.Add("@LugarMantenimiento", MySqlDbType.Bit).Value = user.LugarMantenimiento;
                        comando.ExecuteNonQuery();
                        inserto = true;
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
            return inserto;

        }

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM Usuario ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return dt;
        }

    }
}
