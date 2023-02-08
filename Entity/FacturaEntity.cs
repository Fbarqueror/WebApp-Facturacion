using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaEntity : DBEntity
    {

        public int? IdFactura { get; set; }
        public string Cliente { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;


        public List<FacturaDetalleEntity> Detalle { get; set; } = new List<FacturaDetalleEntity>();

        public DataTable ToDT()
        {

            var dt = new DataTable();
            dt.Columns.Add(new DataColumn("IdProducto", typeof(int)));
            dt.Columns.Add(new DataColumn("Cantidad", typeof(int)));
            
            Detalle.ForEach(
              i => dt.Rows.Add(i.IdProducto, i.Cantidad)
            );
            
            return dt;
        }

    }
}
