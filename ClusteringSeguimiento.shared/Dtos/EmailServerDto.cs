using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Dtos
{
    public class EmailServerDto
    {
        public string? EmailServer { get; set; }
        public int EmailPort { get; set; }
        public string? EmailFromName { get; set; }
        public string? EmailFromEmail { get; set; }
        public string? Page { get; set; }
        public string? Titulo { get; set; }
        public string? Destinatario { get; set; }
        public string? Mensaje { get; set; }
    }
}
