using Edura.Entity;
using Edura.Repository.Abstract;

namespace Edura.Repository.Concrete.EntityFramework
{
    class EfOrderRepository : EfGenericRepository<Order>, IOrderRepository
    {
        public EfOrderRepository(EduraContext context) : base(context)
        {

        }
    }
}
