using Edura.Entity;
using Edura.Repository.Abstract;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IUnitOfWork unitOfWork;
        public AdminController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatalogList()
        {
            var model = new CatalogListModel()
            {
                Categories = unitOfWork.Categories.GetAll().ToList(),
                Products = unitOfWork.Products.GetAll().ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCategory(Category entity)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Categories.Add(entity);
                unitOfWork.SaveChanges();

                return Ok(entity);
            }

            return BadRequest();
        }
    }
}
