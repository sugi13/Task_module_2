using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Office;

namespace Screen_design_2.Models
{
    public class Routelist
    {
        public string? equipment { get; set; }
        
        public string? Starting { get; set; }
        
        public string? Destination { get; set; }
        
        public string? Next { get; set; } 
    }
}