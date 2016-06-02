using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApp.Models
{
    public class Tweet
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("retweeted")]
        public bool Retweeted { get; set; }

        public User User { get; set; }

        public Tweet()
        {

        }

    }
}
