using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterStream
{
    internal class Entity
    {
        [JsonProperty(PropertyName = "hashtags")]
        public Hashtag[] Hashtags { get; set; }
    }
}
