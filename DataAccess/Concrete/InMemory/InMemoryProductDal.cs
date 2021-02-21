using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                 new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                  new Product{CategoryId=2,ProductId=3,ProductName="Buzdolabı",UnitPrice=3000,UnitsInStock=5},
                   new Product{CategoryId=2,ProductId=4,ProductName="Televizyon",UnitPrice=15000,UnitsInStock=150},
                    new Product{CategoryId=3,ProductId=5,ProductName="Klavye",UnitPrice=150,UnitsInStock=10},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete =_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryId = product.CategoryId;
            productUpdate.UnitPrice = product.UnitPrice;
            productUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
