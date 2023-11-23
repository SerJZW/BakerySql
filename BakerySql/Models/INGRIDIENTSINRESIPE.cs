using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySql.Models
{
    public class INGRIDIENTSINRESIPE
    {

        [Key]
        public int ID_Recipe { get; set; }
        public int ID_Ingridients { get; set; }
    }
}
