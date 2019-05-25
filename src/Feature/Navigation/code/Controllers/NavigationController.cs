namespace Pintle.Feature.Navigation.Controllers
{
	using System.Web.Mvc;

	public class NavigationController : Controller
	{
		private readonly NavigationService navigationService;

		public NavigationController(NavigationService navigationService)
		{
			this.navigationService = navigationService;
		}

		public ActionResult MainNavigation()
		{
			var model = this.navigationService.GetMainNavigation();
			return this.View(model);
		}
	}
}