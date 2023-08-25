using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Dtos
{
    public class AuthenticationDto
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string? username { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string? password { get; set; }
    }
}
