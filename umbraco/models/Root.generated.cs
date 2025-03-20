//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v15.2.3+ebb6a58
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>root</summary>
	[PublishedModel("root")]
	public partial class Root : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		public new const string ModelTypeAlias = "root";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedContentTypeCache contentTypeCache)
			=> PublishedModelUtility.GetModelContentType(contentTypeCache, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedContentTypeCache contentTypeCache, Expression<Func<Root, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(contentTypeCache), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Root(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// gallery
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gallery")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops> Gallery => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.MediaWithCrops>>(_publishedValueFallback, "gallery");

		///<summary>
		/// keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("keywords")]
		public virtual string Keywords => this.Value<string>(_publishedValueFallback, "keywords");

		///<summary>
		/// lead
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("lead")]
		public virtual string Lead => this.Value<string>(_publishedValueFallback, "lead");

		///<summary>
		/// leadarticle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("leadarticle")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Leadarticle => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "leadarticle");

		///<summary>
		/// metaDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => this.Value<string>(_publishedValueFallback, "metaDescription");

		///<summary>
		/// primaryImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("primaryImage")]
		public virtual global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ImageCropperValue PrimaryImage => this.Value<global::Umbraco.Cms.Core.PropertyEditors.ValueConverters.ImageCropperValue>(_publishedValueFallback, "primaryImage");

		///<summary>
		/// title: Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.2.3+ebb6a58")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => this.Value<string>(_publishedValueFallback, "title");
	}
}
