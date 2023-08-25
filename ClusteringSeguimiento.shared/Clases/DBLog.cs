using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Clases
{
    public class DBLog
    {
        public int Id { get; set; }
        public string? Funcion { get; set; }
        public string? Descripcion { get; set; }
        public int Userid { get; set; }
        public string? Username { get; set; }
        public string? Userroll { get; set; }
        public int Respuesta_id { get; set; }
        public int Estado_id { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
    }
}
