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
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }

        public Category GetCategoryById(int id)
        {
            if (id > 0)
            {
                return _categoryRepository.GetCategoryById(id);
            }
            throw new Exception("id i den küçük olamaz");
        }
    }
}
