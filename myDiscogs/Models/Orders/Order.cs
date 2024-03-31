using myDiscogs.Models.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Orders
{
    public class Order
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("messages_url")]
        public string MessagesUrl { get; set; }

        [JsonProperty("buyer")]
        public Buyer Buyer { get; set; }

        [JsonProperty("seller")]
        public Seller Seller { get; set; }

        [JsonProperty("feedback")]
        public Feedback Feedback { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("last_activity")]
        public DateTime LastActivity { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("next_status")]
        public List<string> NextStatus { get; set; }

        [JsonProperty("tax")]
        public List<Tax> Tax { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("additional_instructions")]
        public string AdditionalInstructions { get; set; }

        [JsonProperty("fee")]
        public Fee Fee { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("tracking")]
        public Tracking Tracking { get; set; }

        [JsonProperty("buyer_fee")]
        public object BuyerFee { get; set; }

        [JsonProperty("tax_on_buyer_fee")]
        public object TaxOnBuyerFee { get; set; }
    }
}