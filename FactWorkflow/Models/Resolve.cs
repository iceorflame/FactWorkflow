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
        public int ResId { get; set; }

        public int? DId { get; set; }
        public Document Document { get; set; }

        public int? UId { get; set; }
        public User User { get; set; }

        public string RAddress { get; set; }
        public string RStatus { get; set; }
    }
}
