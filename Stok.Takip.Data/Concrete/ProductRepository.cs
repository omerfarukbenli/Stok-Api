using Stok.Takip.Data.Abstract;
using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Data.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Products.Add(product);
                dataContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var dataContext = new DataContext())
            {
                var deletedProduct = GetProductById(id);
                dataContext.Products.Remove(deletedProduct);
                dataContext.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Products.Find(id);
            }
        }
    }
}
