//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Zbu.ModelsBuilder v2.0.0.26
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Zbu.ModelsBuilder;
using Zbu.ModelsBuilder.Umbraco;

namespace Umbraco.Extensions.Models.Generated
{
	/// <summary>Home</summary>
	[PublishedContentModel("Home")]
	public partial class Home : Menu
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

	}
}
