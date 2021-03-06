using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        [Key]
        public string CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
