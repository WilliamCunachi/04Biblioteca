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
    public class LibroController
    {
        private ConexionBDD conexion = new ConexionBDD();
        private SqlCommand comando = new SqlCommand();
        public bool AgregarLibro(Libros libros)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Libros(titulo, autor, genero, año_publicacion) VALUES (@titulo, @autor, @genero, @año_publicacion)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@titulo", libros.titulo);
                comando.Parameters.AddWithValue("@autor", libros.autor);
                comando.Parameters.AddWithValue("@genero", libros.genero);
                comando.Parameters.AddWithValue("@año_publicacion", libros.año_publicacion);
                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar libro : " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }
        public bool ModificarLibro(Libros libros)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Libros(titulo, autor, genero, año_publicacion) VALUES (@titulo, @autor, @genero, @año_publicacion)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@titulo", libros.titulo);
                comando.Parameters.AddWithValue("@autor", libros.autor);
                comando.Parameters.AddWithValue("@genero", libros.genero);
                comando.Parameters.AddWithValue("@año_publicacion", libros.año_publicacion);
                comando.Parameters.AddWithValue("@libro_id", libros.libro_id);
                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar libro : " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }
        public bool EliminarLibro(int libro_id)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "DELETE FROM Libros WHERE libro_id = @libro_id";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@libro_id", libro_id);

                int filasAfectadas = comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar libro: " + ex.Message);
                conexion.CerrarConexion();
                return false;
            }
        }
        public List<Libros> ObtenerLibros()
        {
            List<Libros> listaLibros = new List<Libros>();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT libro_id, titulo, autor, genero, año_publicacion  FROM Libros";
                comando.CommandType = CommandType.Text;

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Libros libros = new Libros
                    {
                        libro_id = reader.GetInt32(0),
                        titulo = reader.GetString(1),
                        autor = reader.GetString(2),
                        genero = reader.GetString(3),
                        año_publicacion = reader.GetInt32(4),
                    };
                    listaLibros.Add(libros);
                }
                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener libros: " + ex.Message);
                conexion.CerrarConexion();
            }
            return listaLibros;
        }
    }
}
