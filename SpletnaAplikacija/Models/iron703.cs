﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpletnaAplik.Models
{
    public class ironman703
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string genderRank { get; set; }
        public string divRank { get; set; }
        public string overallRank { get; set; }
        public string bib { get; set; }
        public string division { get; set; }
        public string age { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string profession { get; set; }
        public string points { get; set; }
        public string swim { get; set; }
        public string swimDistance { get; set; }
        public string t1 { get; set; }
        public string bike { get; set; }
        public string bikeDistance { get; set; }
        public string t2 { get; set; }
        public string run { get; set; }
        public string runDistance { get; set; }
        public string overall { get; set; }
    }
}
