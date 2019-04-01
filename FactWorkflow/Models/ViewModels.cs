using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class SendResolve
    {
        public Resolve Resolve { get; set; }
        public IEnumerable<History> Histories { get; set; }
    }

    public class AddResolve
    {
        public History History { get; set; }
        public Resolve Resolve { get; set; }
    }
}
