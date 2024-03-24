using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Inventory
{
    public class Stats
    {
        public int Id { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("stars")]
        public double Stars { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("community")]
        public Community Community { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}