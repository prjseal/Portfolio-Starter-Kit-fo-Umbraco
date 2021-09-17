using System;
using Umbraco.Cms.Core.Packaging;
using Umbraco.Cms.Infrastructure.Packaging;

namespace Portfolio.Migrations
{
    public class StarterKitPackageMigrationPlan : PackageMigrationPlan
    {
        public StarterKitPackageMigrationPlan()
            : base("Portfolio-Starter-Kit")
        {
        }

        protected override void DefinePlan()
        {
            To<ImportPackageXmlMigration>(new Guid("7858F590-FAEF-4D68-9A52-6F9C67239858"));
        }
    }
}