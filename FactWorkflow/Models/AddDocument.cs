using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class AddDocument
    {
        [Required]
        public string DocumentFrom { get; set; }

        [Required]
        public string DocumentAbout { get; set; }

        [Required]
        public string DocumentOut { get; set; }
    }
}
