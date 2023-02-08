using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductoEntity : DBEntity
    {

        public int? IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool IVA { get; set; }
        public decimal Total { get; set; }

        public decimal Impuesto { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public string UsuarioRegistro { get; set; }
    }
}
