using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Models
{
    public class User
    {
        public long? Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
        public bool Vote { get; set; }
    }
}
