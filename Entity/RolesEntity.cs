using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RolesEntity : DBEntity
    {
        public int? IdRoles { get; set; }
        public string Nombre { get; set; }
        public bool Menu_Productos { get; set; }
        public bool Menu_Usuarios { get; set; }
        public bool Menu_Roles { get; set; }
        public bool Menu_Bitacoras { get; set; }

        public bool Actualizar_Productos { get; set; }
        public bool Actualizar_Usuarios { get; set; }
        public bool Actualizar_Roles { get; set; }
        public bool Eliminar_Productos { get; set; }
        public bool Eliminar_Usuarios { get; set; }
        public bool Eliminar_Roles { get; set; }

        public string UsuarioRegistro { get; set; }
    }
}
