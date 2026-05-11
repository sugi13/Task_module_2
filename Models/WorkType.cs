using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Screen_design_2.Models
{
    public class WorkType
    {
       [Required (ErrorMessage = "Enter Work Type")]
       public string? Work_Type {get; set;}
       
       [Required (ErrorMessage = "Enter Description")]
       public string? Description {get; set;}
       
       [Required (ErrorMessage = "Enter Task Priority")]
       public string? Task_priority {get; set;}
       
       public string? Execution {get; set;}
       
       public string? Routes {get; set;}
       
       public string? Equipments {get; set;}        
    }
}