using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Collection
{
    public class Urls
    {
        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}