using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Collection
{
    public class PaginatedCollection
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("releases")]
        public List<Release> Releases { get; set; }
    }
}