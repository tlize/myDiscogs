using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Inventory
{
    public class User
    {
        [JsonProperty("in_wantlist")]
        public int InWantlist { get; set; }

        [JsonProperty("in_collection")]
        public int InCollection { get; set; }
    }
}