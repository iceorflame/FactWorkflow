using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Type
    {
        [Key]
        public int TId { get; set; }

        public string TName { get; set; }

        public List<History> Histories { get; set; }

        public Type()
        {
            Histories = new List<History>();
        }
    }
}
