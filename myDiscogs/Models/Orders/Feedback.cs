using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Feedback
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("for_buyer")]
        public ForBuyer ForBuyer { get; set; }
    }
}