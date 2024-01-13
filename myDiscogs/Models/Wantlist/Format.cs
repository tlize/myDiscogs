using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class Format
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("qty")]
        public string Qty { get; set; }

        [JsonProperty("descriptions")]
        public List<string> Descriptions { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}