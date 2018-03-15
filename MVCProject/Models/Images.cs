using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Images
    {
        public int ID { get; set; }
        public virtual Post Post { get; set; }
        public string ImagePath { get; set; }
    }
}
