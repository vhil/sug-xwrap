using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;
using Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/Metadata/Data/_Metadata

namespace Pintle.Feature.Metadata.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template '_Metadata'.
	/// Template ID: {6DFCD868-11BF-43D4-9497-2D0EBD2D764E}.
	/// Template path: /sitecore/templates/Feature/Metadata/Data/_Metadata.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _MetadataItem : ItemWrapper
	{
		public _MetadataItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'multi-line text' field for item field with name: 'Meta description'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaDescription => this.WrapField<ITextFieldWrapper>(FieldNames.MetaDescription);

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Meta keywords'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaKeywords => this.WrapField<ITextFieldWrapper>(FieldNames.MetaKeywords);

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Meta title'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaTitle => this.WrapField<ITextFieldWrapper>(FieldNames.MetaTitle);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{6DFCD868-11BF-43D4-9497-2D0EBD2D764E}"; 
		}

		public static class FieldNames
		{
			public const string MetaDescription = "Meta description"; 
			public const string MetaKeywords = "Meta keywords"; 
			public const string MetaTitle = "Meta title"; 
		}

		public static class FieldIds
		{
			public static ID MetaDescription = new ID("{0B3A66CF-96BF-4995-A945-2F561A8800D3}"); 
			public static ID MetaKeywords = new ID("{EC267426-9CD2-4531-A7C8-F132C5F9D8F9}"); 
			public static ID MetaTitle = new ID("{9338949C-7195-4C74-AB94-1AF36E78B3CA}"); 
		}
	}
}

#endregion
