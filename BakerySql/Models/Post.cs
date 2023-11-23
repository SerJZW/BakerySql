using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class Post
    {
        [Key]
        public int Post_ID { get; set; }
        public string? Post_Name { get; set; }
        public decimal? Salary { get; set; }
    }
}
