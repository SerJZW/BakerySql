using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class COOKING_PRODUCT
    {
        [Key]
        public int Cooking_ID { get; set; }
        public int Recipe_ID { get; set; }

        [ForeignKey("Employee_ID")]
        public int Employee_ID { get; set; }
        public DateTime DateCooking { get; set; }
        public int CountProduct { get; set; }
        public decimal Price { get; set; }
    }
}
