using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public enum AcountType
    {
        Personal ,
        Organizational
    }
    [Table("Donor")]
    public class Donor : ApplicationUser
    {
        public AccountType Type { get; set; }
    }
}
