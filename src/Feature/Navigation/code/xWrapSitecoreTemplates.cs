using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;
using Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/Navigation/Data/_Navigation

namespace Pintle.Feature.Navigation.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template '_Navigation'.
	/// Template ID: {1F29690D-85AD-4F1D-8520-36ED44F72843}.
	/// Template path: /sitecore/templates/Feature/Navigation/Data/_Navigation.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _NavigationItem : ItemWrapper
	{
		public _NavigationItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'checkbox' field for item field with name: 'Hide from navigation'.
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper HideFromNavigation => this.WrapField<ICheckboxFieldWrapper>(FieldNames.HideFromNavigation);

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Navigation title'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper NavigationTitle => this.WrapField<ITextFieldWrapper>(FieldNames.NavigationTitle);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{1F29690D-85AD-4F1D-8520-36ED44F72843}"; 
		}

		public static class FieldNames
		{
			public const string HideFromNavigation = "Hide from navigation"; 
			public const string NavigationTitle = "Navigation title"; 
		}

		public static class FieldIds
		{
			public static ID HideFromNavigation = new ID("{F32502B4-29AD-4544-8175-2A2ED3EC12B9}"); 
			public static ID NavigationTitle = new ID("{3EB710B1-2611-4350-8646-1ADCE39F6904}"); 
		}
	}
}

#endregion
