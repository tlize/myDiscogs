using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Tracking
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}