using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Deal
    {
        [Key, ForeignKey("proposal"),DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int DealID { get; set; }
        public virtual ApplyProposal proposal { get; set; }
    }
}
