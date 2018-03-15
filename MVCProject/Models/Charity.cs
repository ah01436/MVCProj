using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    [Table("Charity")]
   public class Charity :ApplicationUser
    {
        public string RegisterationNumber { get; set; }
        public string BankAccountNumber { get; set; }
    }
}
