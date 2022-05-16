using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Data.Abstract
{
    public interface IProductRepository
    {
        Product CreateProduct(Product product);
        Product GetProductById(int id);
        void DeleteProduct(int id);
    }
}
