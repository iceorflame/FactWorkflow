using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class File
    {
        [Key]
        public int FId { get; set; }
        public string FName { get; set; }
        public string FType { get; set; }
        public byte[] FByte { get; set; }

        public List<Document> Documents { get; set; }

        public File()
        {
            Documents = new List<Document>();
        }
    }
}
