using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UporabVmesnik.Models
{
    public class Oseba
    {
        [Key]
        public string id { get; set; }
        public string ime { get; set; }
        public string geslo { get; set; }
        public bool admin { get; set; }
    }
}
