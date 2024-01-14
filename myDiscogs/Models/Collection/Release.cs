using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Collection
{
    public class Release
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("instance_id")]
        public int InstanceId { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("basic_information")]
        public BasicInformation BasicInformation { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }
    }
}