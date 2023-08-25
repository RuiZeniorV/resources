using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TPermiso : ICloneable
    {
        public int Id { get; set; }
        public int Rol_id { get; set; }
        public int ProcesoId { get; set; }
        public string? Rol { get; set; }
        public string? Proceso { get; set; }
        public string? Estado { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
