using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BakerySql.Models
{
    public class RECIPE
    {
        [Key]
        public int Recipe_ID { get; set; }
        public int Equipment_ID { get; set; }
        public string? Recipe_Name { get; set; }
        public TimeSpan CookingTime { get; set; }
        public int Calories { get; set; }
    }
}
