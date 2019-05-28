using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;

namespace XwrapDemo.Project.Website
{
	[TemplateId("{76036F5E-CBCE-46D1-AF0A-4143F9B557AA}")]
	public class SampleItem : ItemWrapper
	{
		public SampleItem(Item item) : base(item)
		{
		}

		public ITextFieldWrapper Title => this.WrapField<ITextFieldWrapper>("title");
		public IRichTextFieldWrapper Text => this.WrapField<IRichTextFieldWrapper>("text");
		public IDateTimeFieldWrapper Timestamp => this.WrapField<IDateTimeFieldWrapper>("timestamp");
		public IListFieldWrapper Related => this.WrapField<IListFieldWrapper>("related items");
	}

	public class Foo
	{
		public void Bar()
		{
			var sampleItem = new SampleItem(Sitecore.Context.Item);
		}
	}
}