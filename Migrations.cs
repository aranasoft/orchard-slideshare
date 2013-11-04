using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using SlideShare.Models;

namespace SlideShare {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            // Creating table SlideShareRecord
            SchemaBuilder.CreateTable("SlideShareRecord",
                table => table
                    .ContentPartRecord()
                    .Column<string>("SlideShareId")
                    .Column<int>("StartFromSlide")
                );

            ContentDefinitionManager.AlterPartDefinition(
                typeof (SlideSharePart).Name, cfg => cfg.Attachable());
            return 2;
        }
    }
}