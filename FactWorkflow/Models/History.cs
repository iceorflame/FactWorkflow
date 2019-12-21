using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class History
    {
        [Key]
        public int Hid { get; set; }

        public int HUser { get; set; }

        [ForeignKey("HUser")]
        public User UserOut { get; set; }

        public int TId { get; set; }
        public Type Type { get; set; }

        public DateTime? HDate { get; set; }

        public int DId { get; set; }
        public Document Document { get; set; }

        public int UId { get; set; }

        [ForeignKey("UId")]
        public User User { get; set; }

        public bool? HResponsible { get; set; }

        public bool? HOriginal { get; set; }

        public string HAddress { get; set; }

        public string HText { get; set; }

        public int SId { get; set; }
        public Status Status { get; set; }

        public int? AId { get; set; }
        public Answer Answer { get; set; }
    }
}
