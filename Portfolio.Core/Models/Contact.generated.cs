//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602
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
	/// <summary>Contact</summary>
	[PublishedModel("contact")]
	public partial class Contact : PublishedContentModel, IMainContentProperties, IMainHeaderControls, ISEocontrols, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const string ModelTypeAlias = "contact";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Contact, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Contact(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Main Content: Add the different content rows using the block list editor
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("mainContent")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainContent => global::Umbraco.Cms.Web.Common.PublishedModels.MainContentProperties.GetMainContent(this, _publishedValueFallback);

		///<summary>
		/// Title: Enter a title for this page. If this is left blank, the name of the page will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.MainHeaderControls.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// Canonical Url: Enter the canonical url for this page. If it is empty, the url of the page will be used instead.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("canonicalUrl")]
		public virtual string CanonicalUrl => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetCanonicalUrl(this, _publishedValueFallback);

		///<summary>
		/// Meta Description: Enter the meta description for the page. This is what will show in search engine results.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Title: Enter the title for the page. If this is blank, we will use page title. If that is blank we will use page name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("metaTitle")]
		public virtual string MetaTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SEocontrols.GetMetaTitle(this, _publishedValueFallback);

		///<summary>
		/// Hide From Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("hideFromSitemap")]
		public virtual bool HideFromSitemap => global::Umbraco.Cms.Web.Common.PublishedModels.VisibilityControls.GetHideFromSitemap(this, _publishedValueFallback);

		///<summary>
		/// Umbraco Navi Hide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Cms.Web.Common.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this, _publishedValueFallback);
	}
}
