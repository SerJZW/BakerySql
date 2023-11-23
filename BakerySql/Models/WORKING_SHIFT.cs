using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class WORKING_SHIFT
    {
        [Key]
        public int Working_shift_ID { get; set; }
        public string? Work_shedule { get; set; }
        public int Work_time { get; set; }
    }
}
