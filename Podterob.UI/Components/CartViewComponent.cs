using Microsoft.AspNetCore.Mvc;
using Podterob.Domain.Entities;
using Podterob.UI.Extensions;

namespace Podterob.UI.Components
{
	public class CartViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var cart = HttpContext.Session.Get<Cart>("cart");
			return View(cart);
		}
	}
}
