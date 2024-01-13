using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class Artist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("anv")]
        public string Anv { get; set; }

        [JsonProperty("join")]
        public string Join { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("tracks")]
        public string Tracks { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}