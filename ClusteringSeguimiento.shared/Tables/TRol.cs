using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TRol : ICloneable
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
