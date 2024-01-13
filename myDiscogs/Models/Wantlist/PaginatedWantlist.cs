using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class PaginatedWantlist
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("wants")]
        public List<Want> Wants { get; set; }
    }
}