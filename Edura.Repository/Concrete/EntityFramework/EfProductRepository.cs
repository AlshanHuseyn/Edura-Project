using Edura.Entity;
using Edura.Repository.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductrepository
    {
        public EfProductRepository(EduraContext context) : base(context)
        {

        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public List<Product> GetTop5Products()
        {
            return EduraContext.Products
                .OrderByDescending(m => m.ProductId)
                .Take(5)
                .ToList();
        }
    }
}
