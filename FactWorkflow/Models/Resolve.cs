using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Resolve
    {
        [Key]
        public int RId { get; set; }

        public int DId { get; set; }
        public Document Document { get; set; }

        public string RText { get; set; }

        public int? SId { get; set; }
        public Status Status { get; set; }
    }
}
