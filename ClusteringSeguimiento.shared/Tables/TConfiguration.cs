using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringSeguimiento.Shared.Tables
{
    /// <summary>
    /// TABLE SYSTEM CONFIGURATION
    /// </summary>
    public class TConfiguration
    {
        public int Id { get; set; }
        public string? ADUser { get; set; }
        public string? NameApp { get; set; }
        public string? ADPassword { get; set; }
        public string? ADHost { get; set; }
        public string? ADDomain { get; set; }
        public int ADPort { get; set; }
        public string? ADBaseDN { get; set; }
        public int IsADActivo { get; set; }
        public int InactivityTime { get; set; }
        public int MaxIntentosLogin { get; set; }
        public string? EmailServer { get; set; }
        public int EmailPort { get; set; }
        public string? RRHHEmailGroup { get; set; }
        public string? SecurityEmailGroup { get; set; }
        public string? EmailFromName { get; set; }
        public string? EmailFromEmail { get; set; }
        public string? FechaCreacion { get; set; }
        public string? FechaEdicion { get; set; }
    }
}
