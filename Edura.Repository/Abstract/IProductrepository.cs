using Edura.Entity;
using System.Collections.Generic;

namespace Edura.Repository.Abstract
{
    public interface IProductrepository : IGenericRepository<Product>
    {
        List<Product> GetTop5Products();
    }
}
