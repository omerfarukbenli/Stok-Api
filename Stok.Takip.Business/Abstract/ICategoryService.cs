using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Business.Abstract
{
    public interface ICategoryService
    {
        Category CreateCategory(Category category);
        Category GetCategoryById(int id);
        void DeleteCategory(int id);
    }
}
