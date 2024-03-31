using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Price
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("curr_abbr")]
        public string CurrAbbr { get; set; }

        [JsonProperty("curr_id")]
        public int CurrId { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("converted")]
        public Converted Converted { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}