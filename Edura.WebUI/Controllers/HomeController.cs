using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork unitOfWork;
        public HomeController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index()
        {
            return View(unitOfWork.Products.GetAll().Where(m => m.IsAppreoved && m.IsHome).ToList());
        }

        public IActionResult Details(int id)
        {
            return View(unitOfWork.Products.Get(id));
        }

    }
}
