using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CRUDusingEF_Entity_framework_.Models
{
    
    // EF
    // Run on the top of ADO.NET
    //EF is an ORM solution(object relational mapping)

    [Table("Product")]
    public class Product
    {
        [Key]
       public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}
