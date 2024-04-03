using DAL;
using DAL.Entities;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        public List<ProductReadVM> GetProducts()
        {
            var productList = ApplicationDbContext.ProductList;
            return productList.Select(product => new ProductReadVM
            {
                Id = product.Id,
                Name = product.Name,
                CreateTime = product.CreateTime
            }).ToList();
        }

        public void CreateProduct(ProductCreateVM product)
        {
            var productModel = new Product
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
            ApplicationDbContext.ProductList.Add(productModel);
        }
    }
}
