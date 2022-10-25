using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterStream
{
    internal class Tweet
    {
        [JsonProperty(PropertyName = "data")]
        public TweetData Data { get; set; }
    }
}
