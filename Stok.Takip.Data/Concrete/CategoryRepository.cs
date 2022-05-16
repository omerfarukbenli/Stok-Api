using Stok.Takip.Data.Abstract;
using Stok.Takip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok.Takip.Data.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {

        public Category CreateCategory(Category category)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Categories.Add(category);
                dataContext.SaveChanges();
                return category;
            }
        }

        public Category GetCategoryById(int id)
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Categories.Find(id);
            }
        }

        public void DeleteCategory(int id)
        {
            using (var dataContext = new DataContext())
            {
                var deletedCategory = GetCategoryById(id);
                dataContext.Categories.Remove(deletedCategory);
                dataContext.SaveChanges();
            }
        }
    }
}
