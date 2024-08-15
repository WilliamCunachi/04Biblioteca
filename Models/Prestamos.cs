using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Biblioteca.Models
{
    public class Prestamos
    {
        public int prestamo_id { get; set; }
        public string libro_id { get; set; }
        public string miembro_id { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_devolucion { get; set; }
    }
}
