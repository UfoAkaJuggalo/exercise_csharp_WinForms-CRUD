﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika_psychiatryczna.Models
{
    public class Pacjent
    {
        public string PName { get; set; }
        public string PLastName { get; set; }
        public System.DateTime PDOB { get; set; }
        public string PCity { get; set; }
    }
}
