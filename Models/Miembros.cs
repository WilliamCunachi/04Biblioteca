using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Biblioteca.Models
{
    public class Miembros
    {
        public int miembro_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public DateTime fecha_suscripcion { get; set; }
    }
}
