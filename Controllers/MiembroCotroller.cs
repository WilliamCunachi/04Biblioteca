using _04Biblioteca.Config;
using _04Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Biblioteca.Controllers
{
       public class MiembroCotroller
    {
        private ConexionBDD conexion = new ConexionBDD();
        private SqlCommand comando = new SqlCommand();


      public bool AgregarMiembro(Miembros miembros)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Miembros(nombre, apellido, email, fecha_suscripcion) VALUES (@nombre, @apellido, @email, @fecha_suscripcion)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@nombre", miembros.nombre);
                comando.Parameters.AddWithValue("@apellido", miembros.apellido);
                comando.Parameters.AddWithValue("@email", miembros.email);
                comando.Parameters.AddWithValue("@fecha_suscripcion", miembros.fecha_suscripcion);

                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar miembro: " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }

        public bool ModificarMiembro(Miembros miembros)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "UPDATE Miembros SET nombre = @nombre, apellido = @apellido, email = @email, fecha_suscripcion = @fecha_suscripcion WHERE miembro_id = @miembro_id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@nombre", miembros.nombre);
                comando.Parameters.AddWithValue("@apellido", miembros.apellido);
                comando.Parameters.AddWithValue("@email", miembros.email);
                comando.Parameters.AddWithValue("@fecha_suscripcion", miembros.fecha_suscripcion);
                comando.Parameters.AddWithValue("@miembro_id", miembros.miembro_id);

                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar miembro: " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }

        public bool EliminarMiembro(int miembro_id)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM Miembros WHERE miembro_id = @miembro_id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@miembro_id", miembro_id);

                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar miembro: " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }

        public List<Miembros> ObtenerMiembros()
        {
            List<Miembros> listaMiembros = new List<Miembros>();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT miembro_id, nombre, apellido, email, fecha_suscripcion FROM Miembros";
                comando.CommandType = CommandType.Text;

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Miembros miembros = new Miembros
                    {
                        miembro_id = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        apellido = reader.GetString(2),
                        email = reader.GetString(3),
                        fecha_suscripcion = reader.GetDateTime(4)
                    };
                    listaMiembros.Add(miembros);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener miembros: " + ex.Message);
                conexion.CerrarConexion();
            }

            return listaMiembros;
        }
    } 

        }
    

