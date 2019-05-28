using System.Collections.Generic;
using System.Linq;
using Pintle.Feature.Navigation.SitecoreTemplates;
using Xwrap.Extensions;

namespace Pintle.Feature.Navigation
{
	public class NavigationService
	{
		public IEnumerable<_NavigationItem> GetMainNavigation()
		{
			var root = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
			return root.WrapChildren<_NavigationItem>().Where(x => !x.HideFromNavigation.Value);
		}
	}
}