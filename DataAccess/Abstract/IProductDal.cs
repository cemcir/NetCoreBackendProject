using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // I interface olduğunu bildirir
    // Product veritabanı tablosu olduğunu anlatır
    // Dal hangi katmanda olduğunu anlatır
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();       
    }
}
