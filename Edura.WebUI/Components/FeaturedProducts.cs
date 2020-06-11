using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductrepository productrepository;
        public FeaturedProducts(IProductrepository _productrepository)
        {
            productrepository = _productrepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(productrepository
                .GetAll()
                .Where(m => m.IsAppreoved && m.IsFeatured)
                .ToList());
        }
    }
}
