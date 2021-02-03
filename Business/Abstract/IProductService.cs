using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GettAllByCategoryId(int id);


        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
