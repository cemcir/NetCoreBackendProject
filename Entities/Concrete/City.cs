using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class City:IEntity
    {
        public City()
        {
            Orders = new List<Order>();
            Customers = new List<Customer>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CityId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
