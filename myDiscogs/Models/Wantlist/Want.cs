using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class Want
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("basic_information")]
        public BasicInformation BasicInformation { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}