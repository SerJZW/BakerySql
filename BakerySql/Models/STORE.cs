using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class STORE
    {
        [Key]
        public int ID_Ingridient { get; set; }
        public int ID_Unit { get; set; }
        public string? Ingridient_Name { get; set; }
        public int Ingridient_Count { get; set; }
        public decimal Cost_per_one { get; set; }
    }
}
