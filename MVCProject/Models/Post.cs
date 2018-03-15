using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date_Time { get; set; }
        public int Amount { get; set; }
        public virtual ApplicationUser Account { get; set; }
        public bool Archived { get; set; }
        public virtual ICollection<ApplyProposal>ApplyProposals { get; set; }

    }
}
