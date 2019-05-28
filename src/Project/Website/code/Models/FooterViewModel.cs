using System.Collections.Generic;
using Pintle.Feature.Navigation.SitecoreTemplates;
using Sitecore.Data.Items;
using Xwrap.Mvc;
using XwrapDemo.Project.Website.SitecoreTemplates;

namespace XwrapDemo.Project.Website.Models
{
	public class FooterViewModel : ViewModel<FooterItem>
	{
		public IEnumerable<_NavigationItem> Navigation { get; }

		public FooterViewModel(IViewModel<FooterItem> viewModel, IEnumerable<_NavigationItem> navigation) : base(viewModel)
		{
			this.Navigation = navigation;
		}
	}
}