using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public static bool ProductName { get; set; }

        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
            
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<Product> GettAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);        }
    }
}
