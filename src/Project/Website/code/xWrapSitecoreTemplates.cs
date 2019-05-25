using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;
using Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Project/Website/Page

namespace XwrapDemo.Project.Website.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template 'Page'.
	/// Template ID: {029370F2-26FD-4252-8716-5E0325CF5BB5}.
	/// Template path: /sitecore/templates/Project/Website/Page.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class PageItem : ItemWrapper
	{
		public PageItem(Item item) : base(item)
		{
		}

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{029370F2-26FD-4252-8716-5E0325CF5BB5}"; 
		}

	}
}

#endregion

#region /sitecore/templates/Project/Website/Site root

namespace XwrapDemo.Project.Website.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template 'Site root'.
	/// Template ID: {7514171A-91DE-4066-B4CD-8BFFB06C564B}.
	/// Template path: /sitecore/templates/Project/Website/Site root.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class SiteRootItem : ItemWrapper
	{
		public SiteRootItem(Item item) : base(item)
		{
		}

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{7514171A-91DE-4066-B4CD-8BFFB06C564B}"; 
		}

	}
}

#endregion

#region /sitecore/templates/Project/Website/Components/Footer

namespace XwrapDemo.Project.Website.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template 'Footer'.
	/// Template ID: {92F4A528-16A6-4FEA-B893-DBDE7D99A008}.
	/// Template path: /sitecore/templates/Project/Website/Components/Footer.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class FooterItem : ItemWrapper
	{
		public FooterItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'general link' field for item field with name: 'Footer link'.
		/// <returns><see cref="IGeneralLinkFieldWrapper"/></returns>
		/// </summary>
		public IGeneralLinkFieldWrapper FooterLink => this.WrapField<IGeneralLinkFieldWrapper>(FieldNames.FooterLink);

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Footer signature'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper FooterSignature => this.WrapField<ITextFieldWrapper>(FieldNames.FooterSignature);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{92F4A528-16A6-4FEA-B893-DBDE7D99A008}"; 
		}

		public static class FieldNames
		{
			public const string FooterLink = "Footer link"; 
			public const string FooterSignature = "Footer signature"; 
		}

		public static class FieldIds
		{
			public static ID FooterLink = new ID("{7C80541D-A7BD-4BDE-87F2-B5C93C79307B}"); 
			public static ID FooterSignature = new ID("{8CD3A971-EFF5-4784-8466-A2FC1C77FE8B}"); 
		}
	}
}

#endregion

#region /sitecore/templates/Project/Website/Components/Header

namespace XwrapDemo.Project.Website.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template 'Header'.
	/// Template ID: {E1F15DF4-3DB9-4FF3-B10A-58471A2CAD8D}.
	/// Template path: /sitecore/templates/Project/Website/Components/Header.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class HeaderItem : ItemWrapper
	{
		public HeaderItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'image' field for item field with name: 'Header logo'.
		/// <returns><see cref="IImageFieldWrapper"/></returns>
		/// </summary>
		public IImageFieldWrapper HeaderLogo => this.WrapField<IImageFieldWrapper>(FieldNames.HeaderLogo);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{E1F15DF4-3DB9-4FF3-B10A-58471A2CAD8D}"; 
		}

		public static class FieldNames
		{
			public const string HeaderLogo = "Header logo"; 
		}

		public static class FieldIds
		{
			public static ID HeaderLogo = new ID("{06838665-72A1-4638-A762-0E277714CD89}"); 
		}
	}
}

#endregion
