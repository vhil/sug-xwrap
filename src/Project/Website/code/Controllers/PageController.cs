using System.Web.Mvc;
using Pintle.Feature.Navigation;
using Xwrap.Mvc;
using XwrapDemo.Project.Website.Models;
using XwrapDemo.Project.Website.SitecoreTemplates;

namespace XwrapDemo.Project.Website.Controllers
{
	public class PageController : Controller
	{
		private readonly IViewModelFactory viewModelFactory;
		private readonly NavigationService navigationService;

		public PageController(IViewModelFactory viewModelFactory, NavigationService navigationService)
		{
			this.viewModelFactory = viewModelFactory;
			this.navigationService = navigationService;
		}

		public ActionResult Footer()
		{
			var model = this.viewModelFactory.GetViewModel<FooterItem>();
			var viewModel = new FooterViewModel(model, this.navigationService.GetMainNavigation());
			return this.View(viewModel);
		}
	}
}