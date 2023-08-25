using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TCampo : ICloneable
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int TipoCampoId { get; set; }
        public string? TipoCampo { get; set; }
        public int EstadoClustering { get; set; }
        public int EstadoSeguimiento { get; set; }
        public int EstadoVisualizacion { get; set; }
        public string? Estado { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
