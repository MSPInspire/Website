using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Video
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string SourceShort => Uri.TryCreate(Source, UriKind.Absolute, out var sourceUri) ? sourceUri.Authority : Source;
        public string Image { get; set; }
    }
}
