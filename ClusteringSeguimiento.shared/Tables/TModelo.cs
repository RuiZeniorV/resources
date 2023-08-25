using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TModelo
    {
        public int           Id                   { get; set; }
        public double        InerciaMaxima        { get; set; }
        public double        Inercia              { get; set; }
        public int           CantidadClusters     { get; set; }
        public int           CantidadClientes     { get; set; }
        public int           CantidadMeses        { get; set; }
        public double        PorcentajeDiferencia { get; set; }
        public List<string>? Campos               { get; set; }
        public string?       Comentario           { get; set; }
        public string?       Estado               { get; set; }
        public string?       Autor                { get; set; }
        public int           AutorId              { get; set; }
        public DateTime?     FechaCreacion        { get; set; }
        public DateTime?     FechaEdicion         { get; set; }
    }
}
