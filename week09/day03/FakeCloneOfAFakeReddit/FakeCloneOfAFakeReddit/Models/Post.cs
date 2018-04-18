using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeCloneOfAFakeReddit.Models
{
    public class Post
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; } = DateTime.UtcNow;
        public int Score { get; set; }
    }
}
