using Microsoft.AspNetCore.Mvc;

namespace Escuela_vue.Web.Controllers
{
	public class AlumnosController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
