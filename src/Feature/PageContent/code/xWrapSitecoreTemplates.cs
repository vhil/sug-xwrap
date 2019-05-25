using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;
using Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/PageContent/Data/_Page content

namespace Pintle.Feature.PageContent.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template '_Page content'.
	/// Template ID: {5C5F979C-1608-4DEA-9F31-820036DB38A0}.
	/// Template path: /sitecore/templates/Feature/PageContent/Data/_Page content.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _PageContentItem : ItemWrapper
	{
		public _PageContentItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'rich text' field for item field with name: 'Page body'.
		/// <returns><see cref="IRichTextFieldWrapper"/></returns>
		/// </summary>
		public IRichTextFieldWrapper PageBody => this.WrapField<IRichTextFieldWrapper>(FieldNames.PageBody);

		/// <summary>
		/// A wrapped 'image' field for item field with name: 'Page image'.
		/// <returns><see cref="IImageFieldWrapper"/></returns>
		/// </summary>
		public IImageFieldWrapper PageImage => this.WrapField<IImageFieldWrapper>(FieldNames.PageImage);

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Page title'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper PageTitle => this.WrapField<ITextFieldWrapper>(FieldNames.PageTitle);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{5C5F979C-1608-4DEA-9F31-820036DB38A0}"; 
		}

		public static class FieldNames
		{
			public const string PageBody = "Page body"; 
			public const string PageImage = "Page image"; 
			public const string PageTitle = "Page title"; 
		}

		public static class FieldIds
		{
			public static ID PageBody = new ID("{641D9B92-718E-43F8-91BC-569BC9D8553F}"); 
			public static ID PageImage = new ID("{7E7AEDEF-1E09-4103-AD6B-A11DB57813F4}"); 
			public static ID PageTitle = new ID("{0CE6EB53-685C-4B4F-AFEC-ED0FD30BC188}"); 
		}
	}
}

#endregion

#region /sitecore/templates/Feature/PageContent/Rendering Parameters/Page content parameters

namespace Pintle.Feature.PageContent.SitecoreTemplates
{
	/// <summary>
	/// Rendering parameters wrapper for template 'Page content parameters'.
	/// Template ID: {F16C66BE-B485-44A9-8211-D96FC75C6C17}.
	/// Template path: /sitecore/templates/Feature/PageContent/Rendering Parameters/Page content parameters.
	/// </summary>
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class PageContentParameters : RenderingParametersWrapper
	{
		public PageContentParameters(RenderingParameters parameters) : base(parameters)
		{
		}

		/// <summary>
		/// A wrapped 'checkbox' parameter for field with name 'Hide page title'.
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper HidePageTitle => this.CheckboxField(FieldNames.HidePageTitle);

		public static class FieldNames
		{
			public const string HidePageTitle = "Hide page title"; 
		}
	}
}

#endregion
