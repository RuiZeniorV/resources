using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TCliente
    {
        public int           Id { get; set; }
        public string        Identificacion { get; set; } = "";
        public string        Nombre { get; set; } = "";
        public string        TipoPersona { get; set; } = "";
        public int           Cluster_id { get; set; }
        public int           Estado_id { get; set; }
        public List<string>? ColumnasParametros { get; set; } = new List<string>();
        public List<string>? Parametros { get; set; } = new List<string>();
        public List<double>? ParametrosEquivalentes { get; set; } = new List<double>();
        public List<string>? ColumnasDatosPersonales { get; set; } = new List<string>();
        public List<string>? DatosPersonales { get; set; } = new List<string>();
        public string        Estado { get; set; } = "";
        public DateTime      FechaCreacion { get; set; }
        public DateTime      FechaEdicion { get; set; }
    }
}
