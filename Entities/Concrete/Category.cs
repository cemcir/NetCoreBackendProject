using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    //Kalıtım veya implement almayan class kalmasın
    public class Category:IEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
