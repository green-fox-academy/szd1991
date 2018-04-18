using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Models
{
    public class Post
    {
        public long? Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
        public int Score { get; set; }
    }
}
