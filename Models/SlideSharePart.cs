using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;

namespace SlideShare.Models
{
    public class SlideShareRecord : ContentPartRecord
    {
        public virtual string SlideShareId { get; set; }
        public virtual int? StartFromSlide { get; set; }
    }

    public class SlideSharePart : ContentPart<SlideShareRecord>
    {
        [DisplayName("SlideShare Identifier")]
        public string SlideShareId
        {
            get { return Record.SlideShareId; }
            set { Record.SlideShareId = value; }
        }
        [Range(1, 20)]
        [DisplayName("Start from Slide #")]
        public int? StartFromSlide
        {
            get { return Record.StartFromSlide; }
            set { Record.StartFromSlide = value; }
        }
    }
}