using SlideShare.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace SlideShare.Handlers
{
    public class SlideShareHandler : ContentHandler
    {
        public SlideShareHandler(IRepository<SlideShareRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}