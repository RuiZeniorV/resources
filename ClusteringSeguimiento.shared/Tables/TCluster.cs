using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TCluster
    {
        public int       Id               { get; set; }
        public string?   Nombre           { get; set; }
        public int       Modelo_id        { get; set; }
        public string[]? Columnas         { get; set; }
        public double[]? Parametros       { get; set; }
        public double[]? Minimos          { get; set; }
        public double[]? Maximos          { get; set; }
        public double    Inercia          { get; set; }
        public int       IdClusterVecino  { get; set; }
        public double    Distancia        { get; set; }
        public int       CantidadMiembros { get; set; }
        public string?   Comentario       { get; set; }
        public string?   Estado           { get; set; }
        public int       Estado_id        { get; set; }
        public DateTime? FechaCreacion    { get; set; }
        public DateTime? FechaEdicion     { get; set; }
    }
}
