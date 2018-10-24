using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Token
    {
        [Key]
        public int TId { get; set; }
        public string TToken { get; set; }
    }
}
