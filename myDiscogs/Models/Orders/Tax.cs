using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Tax
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("rate")]
        public int Rate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("display_rate")]
        public string DisplayRate { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("taxable_amount")]
        public TaxableAmount TaxableAmount { get; set; }

        [JsonProperty("remitter")]
        public string Remitter { get; set; }

        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}