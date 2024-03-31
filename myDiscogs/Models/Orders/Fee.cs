﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Fee
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}