using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Document
    {
        [Key]
        public int DId { get; set; }
        public string DIndex { get; set; }
        public DateTime DDate { get; set; }
        public string DFrom { get; set; }
        public string DAbout { get; set; }

        public int? FId { get; set; }
        public File File { get; set; }

        public List<Resolve> Resolves { get; set; }

        public Document()
        {
            Resolves = new List<Resolve>();
        }
    }
}
