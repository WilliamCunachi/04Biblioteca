using _04Biblioteca.Controllers;
using _04Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Biblioteca.Views
{
    public partial class Form2 : Form
    {
        private LibroController libroCotroller;
        public Form2()
        {
            InitializeComponent();
            libroCotroller = new LibroController();
            Cargarlibros();
        }
        private void Cargarlibros()
        {
            
            List<Libros> libros = libroCotroller.ObtenerLibros();
            lstlibros.Items.Clear();
            foreach (Libros libro in libros)
            {
                lstlibros.Items.Add($"{libro.libro_id}:{libro.titulo} {libro.autor}");
            }
        }


        private void btnAgregarLibro_Click_1(object sender, EventArgs e)
        {
            Libros libros = new Libros
            {
                titulo = txt_titulo.Text,
                autor = txt_autor.Text,
                genero = txt_genero.Text,
                año_publicacion = int.Parse(txt_año.Text)

            };
            if (libroCotroller.AgregarLibro(libros))
            {
                MessageBox.Show("Libro agregado con éxito");
                Cargarlibros ();
            }
            else
            {
                MessageBox.Show("Error al agregar miembro");
            }
        }

        private void btnEliminarMiembro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_librosid.Text, out int libro_id))
            {
                if (libroCotroller.EliminarLibro(libro_id))  
                {
                    MessageBox.Show("Libro eliminado con éxito");
                    Cargarlibros();
                }
                else
                {
                    MessageBox.Show("Error al eliminar libro");
                }
            }
            else
            {
                MessageBox.Show("Ingresa un ID de libro válido.");
            }
        }

        private void btnModificarMiembro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_librosid.Text, out int libro_id) &&
        int.TryParse(txt_año.Text, out int año_publicacion)) 
            {
                Libros libros = new Libros
                {
                    libro_id = libro_id,
                    titulo = txt_titulo.Text,
                    autor = txt_autor.Text,
                    genero = txt_genero.Text,
                    año_publicacion = año_publicacion 
                };

                if (libroCotroller.ModificarLibro(libros))
                {
                    MessageBox.Show("Libro modificado con éxito");
                    Cargarlibros();
                }
                else
                {
                    MessageBox.Show("Error al modificar libro");
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos con datos válidos.");
            }
        }
    }
    }

