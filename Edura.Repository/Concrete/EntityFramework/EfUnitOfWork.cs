using Edura.Repository.Abstract;
using System;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly EduraContext dbContext;
        public EfUnitOfWork(EduraContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("dbContext can not null");
        }

        private IProductrepository _products;
        private ICategoryRepository _categories;
        private IOrderRepository _orders;

        public IProductrepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                return _orders ?? (_orders = new EfOrderRepository(dbContext));
            }
        }


        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
