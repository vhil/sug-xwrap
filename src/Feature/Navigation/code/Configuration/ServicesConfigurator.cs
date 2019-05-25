namespace Pintle.Feature.Navigation.Configuration
{
	using Pintle.Foundation.SitecoreExtensions.Extensions;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.DependencyInjection;
	
	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<NavigationService, NavigationService>();
			serviceCollection.AddMvcControllers(this.GetType().Assembly);
		}
	}
}