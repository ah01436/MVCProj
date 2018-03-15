using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    [Table("Food")]

    public class Food :Post
    {
        public DateTime ExpireDate { get; set; }
    }
}
