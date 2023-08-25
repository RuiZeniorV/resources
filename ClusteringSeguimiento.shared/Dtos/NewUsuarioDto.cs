using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Dtos
{
    public class NewUsuarioDto
    {
        public int Rol_id { get; set; }
        public string? Nombre_completo { get; set; }
        public string? Username { get; set; }
        public string? Correo { get; set; }
        public string? Upassword { get; set; }
    }
}
