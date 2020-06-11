using Edura.WebUI.Infrastructure;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Components
{
    public class CartSummaryViewCoponent : ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJson<Cart_>("Cart")?.Products.Count().ToString() ?? "0";
        }
    }
}
