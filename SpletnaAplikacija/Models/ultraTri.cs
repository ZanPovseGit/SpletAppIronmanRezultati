using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpletnaAplik.Models
{
    public class ultratriatlon
    {
        [Key]
        public string id { get; set; }
        public string rank { get; set; }
        public string overall { get; set; }
        public string competitor { get; set; }
        public string country { get; set; }
        public string age_category { get; set; }
        public string swim { get; set; }
        public string trans1 { get; set; }
        public string bike { get; set; }
        public string trans2 { get; set; }
        public string run { get; set; }
        public string finish { get; set; }
        public string comment { get; set; }
    }
}
