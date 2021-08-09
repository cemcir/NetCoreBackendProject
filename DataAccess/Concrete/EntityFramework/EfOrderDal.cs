using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from order in context.Orders
                             join customer in context.Customers
                             on order.CustomerId equals customer.CustomerId
                             join city in context.Cities
                             on order.CityId equals city.CityId
                             join employee in context.Employees
                             on order.EmployeeId equals employee.EmployeeId
                             orderby order.OrderId descending
                             select new OrderDetailDto
                             {
                                 OrderId = order.OrderId, CustomerName = customer.CustomerName,
                                 EmployeeName = employee.EmployeeName, OrderDate = order.OrderDate.ToString("dd/MM/yyyy").Replace("-","/"),
                                 ShipCity=city.Name
                             };
                return result.ToList();
            }    
        }
    }
}
