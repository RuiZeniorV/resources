using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TValorPredeterminado : ICloneable
    {
        public int Id { get; set; }
        public int Campo_id { get; set; }
        public string? NombreCampo { get; set; }
        public string? Valor { get; set; }
        public double Equivalente { get; set; }
        public string? Estado { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
