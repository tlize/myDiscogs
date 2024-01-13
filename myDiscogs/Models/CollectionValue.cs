using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models
{
    public class CollectionValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("maximum")]
        public string Maximum { get; set; }

        [JsonProperty("median")]
        public string Median { get; set; }

        [JsonProperty("minimum")]
        public string Minimum { get; set; }
    }
}