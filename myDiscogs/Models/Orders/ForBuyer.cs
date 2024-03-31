using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class ForBuyer
    {
        [JsonProperty("eligible")]
        public bool Eligible { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("resource_url")]
        public object ResourceUrl { get; set; }
    }
}