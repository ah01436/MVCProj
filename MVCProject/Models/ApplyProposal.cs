using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class ApplyProposal
    {
        public int ID { get; set; }
        public virtual ApplicationUser Account { get; set; }
        public virtual Post post { get; set; }
        public string Contetent { get; set; }
        public virtual Deal Deal { get; set; }
    }
}
