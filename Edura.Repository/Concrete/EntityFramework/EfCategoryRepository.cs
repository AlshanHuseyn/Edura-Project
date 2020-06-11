using Edura.Entity;
using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context) : base(context)
        {

        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public IEnumerable<CategoryMenu> GetAllWithProductCount()
        {
            return GetAll().Select(m => new CategoryMenu()
            {
                CategoryId = m.CategoryId,
                CategoryName = m.CategoryName,
                Count = m.ProductCategories.Count()
            });
        }

        public Category GetByName(string name)
        {
            return EduraContext.Categories
                .Where(m => m.CategoryName == name)
                .FirstOrDefault();
        }
    }
}
