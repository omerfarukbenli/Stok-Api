using Stok.Takip.Business.Abstract;
using Stok.Takip.Data.Abstract;
using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            if (id > 0)
            {
                return _productRepository.GetProductById(id);
            }
            throw new Exception("id i den küçük olamaz");
        }
    }
}
