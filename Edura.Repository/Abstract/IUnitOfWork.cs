using System;

namespace Edura.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductrepository Products { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }

        int SaveChanges();
    }
}
