using System.Web.Mvc;
using Pintle.Feature.Navigation;
using Xwrap.Mvc;

namespace XwrapDemo.Project.Website.Controllers
{
	public class PageController : Controller
	{
		private readonly IViewModelFactory viewModelFactory;

		public PageController(IViewModelFactory viewModelFactory)
		{
			this.viewModelFactory = viewModelFactory;
		}

		public ActionResult Footer()
		{
			return this.View();
		}
	}
}