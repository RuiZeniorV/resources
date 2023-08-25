using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Dtos
{
    public class ValorAnormal
    {
        public int Id {get; set;}
        public int IdCluster {get; set;}
        public string Identificacion {get; set;} = "";
        public string NombreCompleto { get; set; } = "";
        public string TipoPersona { get; set; } = "";
        public string CampoExcedido { get; set; } = "";
        public double ValorMaximo {get; set;}
        public double ValorActual {get; set;}
    }
}
