using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterStream
{
    internal class Hashtag
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}
