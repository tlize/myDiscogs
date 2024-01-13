﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Wantlist
{
    public class Label
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("catno")]
        public string Catno { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("entity_type_name")]
        public string EntityTypeName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }
}