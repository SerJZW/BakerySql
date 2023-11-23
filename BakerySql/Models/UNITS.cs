using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class UNITS
    {
        [Key]
        public int Unit_ID { get; set; }
        public string? Unit_Name { get; set; }
    }
}
