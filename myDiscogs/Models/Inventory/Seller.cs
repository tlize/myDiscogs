using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Inventory
{
    public class Seller
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("min_order_total")]
        public double MinOrderTotal { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("uid")]
        public int Uid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("payment")]
        public string Payment { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}