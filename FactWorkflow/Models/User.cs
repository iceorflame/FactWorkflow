using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class User
    {
        [Key]
        public int UId { get; set; }
        public string UMail { get; set; }
        public string UPassword { get; set; }
        public string UName { get; set; }
    }
}
