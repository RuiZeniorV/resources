using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;


namespace ClusteringSeguimiento.Shared.Dtos
{
    public class LoggedUserDto
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Nombre_completo { get; set; }
        public string? Correo { get; set; }
        public int Rol_id { get; set; }
        public string? Permisos { get; set; }
        public IEnumerable<Claim>? Claims { get; set; }
        public string? Token { get; set; }
        public int ADLogin { get; set; }
        public DateTime LoginDate { get; set; }
    }
}
