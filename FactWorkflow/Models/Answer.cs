using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class Answer
    {
        [Key]
        public int AId { get; set; }
        public string AText { get; set; }

        public int? FId { get; set; }
        public File File { get; set; }

        public List<History> Histories { get; set; }

        public Answer()
        {
            Histories = new List<History>();
        }
    }
}
