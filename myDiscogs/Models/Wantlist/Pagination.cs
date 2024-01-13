using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class Pagination
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }
    }
}