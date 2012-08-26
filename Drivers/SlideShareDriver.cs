using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using SlideShare.Models;

namespace SlideShare.Drivers
{
    public class SlideShareDriver : ContentPartDriver<SlideSharePart>
    {
        protected override DriverResult Display(
            SlideSharePart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_SlideShare",
                                () =>
                                shapeHelper.Parts_SlideShare(
                                    SlideShareId: part.SlideShareId,
                                    StartFromSlide: part.StartFromSlide));
        }

        //GET
        protected override DriverResult Editor(
            SlideSharePart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_SlideShare_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/SlideShare",
                                    Model: part,
                                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(
            SlideSharePart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}