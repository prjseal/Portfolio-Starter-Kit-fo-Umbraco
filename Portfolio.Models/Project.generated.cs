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
	/// <summary>Project</summary>
	[PublishedModel("project")]
	public partial class Project : PublishedContentModel, IMainHeaderControls, IMainImageSettings, IProjectControls, ISEocontrols, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const string ModelTypeAlias = "project";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Project, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Project(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Title: Enter a title for this page. If this is left blank, the name of the page will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.MainHeaderControls.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// Main Image: Choose a main image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("mainImage")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent MainImage => global::Umbraco.Cms.Web.Common.PublishedModels.MainImageSettings.GetMainImage(this, _publishedValueFallback);

		///<summary>
		/// Description: Enter a description for this project
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("description")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Description => global::Umbraco.Cms.Web.Common.PublishedModels.ProjectControls.GetDescription(this, _publishedValueFallback);

		///<summary>
		/// Project Date: Enter a date for this project
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("projectDate")]
		public virtual global::System.DateTime ProjectDate => global::Umbraco.Cms.Web.Common.PublishedModels.ProjectControls.GetProjectDate(this, _publishedValueFallback);

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
		/// Hide: Set this to true if you want to hide this page from the navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc003+36582f2cd2c6ddc797c85dac0a9a6572126bf602")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Cms.Web.Common.PublishedModels.VisibilityControls.GetUmbracoNaviHide(this, _publishedValueFallback);
	}
}