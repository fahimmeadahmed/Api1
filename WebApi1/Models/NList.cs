using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
        public class NList 
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string title { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string description { get; set; }
    }
}
