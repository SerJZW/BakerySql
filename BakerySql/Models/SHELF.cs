using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class SHELF
    {
        [Key]
        public int SHELF_ID { get; set; }
        public int Cooking_ID { get; set; }
        public int Sells { get; set; }
    }
}
