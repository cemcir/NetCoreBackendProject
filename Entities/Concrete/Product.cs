using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    // IEntity implement eden bir class veritabanı tablosudur
    public class Product:IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
