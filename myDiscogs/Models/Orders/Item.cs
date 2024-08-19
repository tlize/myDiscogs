using myDiscogs.Models.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("media_condition")]
        public string MediaCondition { get; set; }

        [JsonProperty("sleeve_condition")]
        public string SleeveCondition { get; set; }

        [JsonProperty("condition_comments")]
        public string ConditionComments { get; set; }

        [JsonProperty("item_location")]
        public string ItemLocation { get; set; }

        [JsonProperty("private_comments")]
        public string PrivateComments { get; set; }

        [JsonProperty("release")]
        public Release Release { get; set; }
    }
}