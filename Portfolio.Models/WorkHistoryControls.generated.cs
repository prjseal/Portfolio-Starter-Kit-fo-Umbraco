//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53
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
	// Mixin Content Type with alias "workHistoryControls"
	/// <summary>CV Controls</summary>
	public partial interface IWorkHistoryControls : IPublishedContent
	{
		/// <summary>Contact Info</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> ContactInfo { get; }

		/// <summary>Contact Info Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ContactInfoTitle { get; }

		/// <summary>Education History</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> EducationHistory { get; }

		/// <summary>Education History Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string EducationHistoryTitle { get; }

		/// <summary>Hobbies</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Hobbies { get; }

		/// <summary>Hobbies Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string HobbiesTitle { get; }

		/// <summary>Skills</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SkillItem> Skills { get; }

		/// <summary>Skills Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SkillsTitle { get; }

		/// <summary>Work History</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> WorkHistory { get; }

		/// <summary>Work History Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string WorkHistoryTitle { get; }
	}

	/// <summary>CV Controls</summary>
	[PublishedModel("workHistoryControls")]
	public partial class WorkHistoryControls : PublishedContentModel, IWorkHistoryControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		public new const string ModelTypeAlias = "workHistoryControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<WorkHistoryControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public WorkHistoryControls(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Contact Info: Enter the contact info
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInfo")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> ContactInfo => GetContactInfo(this, _publishedValueFallback);

		/// <summary>Static getter for Contact Info</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> GetContactInfo(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement>>(publishedValueFallback, "contactInfo");

		///<summary>
		/// Contact Info Title: Enter the title for the contact info section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactInfoTitle")]
		public virtual string ContactInfoTitle => GetContactInfoTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Contact Info Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetContactInfoTitle(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "contactInfoTitle");

		///<summary>
		/// Education History: Enter the details of your education
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("educationHistory")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> EducationHistory => GetEducationHistory(this, _publishedValueFallback);

		/// <summary>Static getter for Education History</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> GetEducationHistory(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem>>(publishedValueFallback, "educationHistory");

		///<summary>
		/// Education History Title: Enter the title for the education history section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("educationHistoryTitle")]
		public virtual string EducationHistoryTitle => GetEducationHistoryTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Education History Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetEducationHistoryTitle(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "educationHistoryTitle");

		///<summary>
		/// Hobbies: Enter the content for the hobbies section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("hobbies")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString Hobbies => GetHobbies(this, _publishedValueFallback);

		/// <summary>Static getter for Hobbies</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Strings.IHtmlEncodedString GetHobbies(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(publishedValueFallback, "hobbies");

		///<summary>
		/// Hobbies Title: Enter a title for the hobbies section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("hobbiesTitle")]
		public virtual string HobbiesTitle => GetHobbiesTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Hobbies Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetHobbiesTitle(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "hobbiesTitle");

		///<summary>
		/// Skills: Enter your skills and ratings
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("skills")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SkillItem> Skills => GetSkills(this, _publishedValueFallback);

		/// <summary>Static getter for Skills</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SkillItem> GetSkills(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.SkillItem>>(publishedValueFallback, "skills");

		///<summary>
		/// Skills Title: Enter the title for the skills section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("skillsTitle")]
		public virtual string SkillsTitle => GetSkillsTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Skills Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSkillsTitle(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "skillsTitle");

		///<summary>
		/// Work History: Enter the details of the places you have worked at
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("workHistory")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> WorkHistory => GetWorkHistory(this, _publishedValueFallback);

		/// <summary>Static getter for Work History</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem> GetWorkHistory(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.HistoryItem>>(publishedValueFallback, "workHistory");

		///<summary>
		/// Work History Title: Enter the title for the work history section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("workHistoryTitle")]
		public virtual string WorkHistoryTitle => GetWorkHistoryTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Work History Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetWorkHistoryTitle(IWorkHistoryControls that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "workHistoryTitle");
	}
}
