using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        public int Post_ID { get; set; }
    
        public int Working_shift_ID { get; set; }
        public string? Name_Employee { get; set; }

        public DateTime Date_Of_Birth { get; set; }
        public int Passport { get; set; }
        public int SNILS { get; set; }
    }
}
