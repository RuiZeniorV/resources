using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    public class TUsuario
    {
        public int Id { get; set; }
        public int Rol_id { get; set; }
        public string? Rol { get; set; }
        public string? Rol_estado { get; set; }
        public string? Nombre_completo { get; set; }
        public string? Username { get; set; }
        public string? Correo { get; set; }
        public string? Upassword { get; set; }
        public string? Estado { get; set; }
        public int ActiveDirectory { get; set; }
        public DateTime LoginDate { get; set; }
        public int FailsLogin { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
    }
}
