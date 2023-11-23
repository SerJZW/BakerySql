using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class EQUIPMENT
    {
        [Key]
        public int Equipment_Id { get; set; }
        public string? Equipment_Name { get; set;}
    }
}
