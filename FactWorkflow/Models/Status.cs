using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Status
    {
        [Key]
        public int SId { get; set; }

        public string SName { get; set; }

        public List<History> Histories { get; set; }
        public List<Resolve> Resolves { get; set; }

        public Status()
        {
            Histories = new List<History>();
            Resolves = new List<Resolve>();
        }
    }
}
