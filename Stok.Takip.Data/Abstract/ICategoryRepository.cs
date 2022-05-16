using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Data.Abstract
{
    public interface ICategoryRepository
    {
        Category CreateCategory(Category category);
        Category GetCategoryById(int id);
        void DeleteCategory(int id);
    }
}
