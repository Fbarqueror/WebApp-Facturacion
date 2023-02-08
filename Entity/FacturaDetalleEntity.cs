using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaDetalleEntity : DBEntity
    {
        

        public int IdProducto{ get; set; }
        public int Cantidad { get; set; }

    }
}
