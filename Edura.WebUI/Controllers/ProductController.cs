using Edura.Entity.Models;
using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Edura.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 2;
        private IProductrepository productrepository;

        public ProductController(IProductrepository _productrepository)
        {
            productrepository = _productrepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category, int page = 1)
        {

            var products = productrepository.GetAll();
            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(m => m.ProductCategories)
                    .ThenInclude(m => m.Category)
                    .Where(m => m.ProductCategories.Any(a => a.Category.CategoryName == category));
            }
            var count = products.Count();
            products = products.Skip((page - 1) * page).Take(PageSize);

            return View(
                new ProductListModel()
                {
                    Products = products,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemPerPage = PageSize,
                        TotalItems = count
                    }
                });
        }

        public IActionResult Details(int id)
        {
            return View
                (
                productrepository.GetAll()
                .Where(m => m.ProductId == id)
                .Include(m => m.Images)
                .Include(m => m.Attributes)
                .Include(m => m.ProductCategories)
                .ThenInclude(m => m.Category)
                .Select(m => new ProductDetailsModel()
                {
                    Product = m,
                    ProductImages = m.Images,
                    ProductAttributes = m.Attributes,
                    Categories = m.ProductCategories.Select(a => a.Category).ToList()
                }).FirstOrDefault());
        }
    }
}
