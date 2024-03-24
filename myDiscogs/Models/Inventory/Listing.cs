using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myDiscogs.Models.Inventory
{
    public class Listing
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("sleeve_condition")]
        public string SleeveCondition { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("ships_from")]
        public string ShipsFrom { get; set; }

        [JsonProperty("posted")]
        public DateTime Posted { get; set; }

        [JsonProperty("allow_offers")]
        public bool AllowOffers { get; set; }

        [JsonProperty("offer_submitted")]
        public bool OfferSubmitted { get; set; }

        [JsonProperty("audio")]
        public bool Audio { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("original_price")]
        public OriginalPrice OriginalPrice { get; set; }

        [JsonProperty("shipping_price")]
        public ShippingPrice ShippingPrice { get; set; }

        [JsonProperty("original_shipping_price")]
        public OriginalShippingPrice OriginalShippingPrice { get; set; }

        [JsonProperty("seller")]
        public Seller Seller { get; set; }

        [JsonProperty("release")]
        public Release Release { get; set; }

        [JsonProperty("in_cart")]
        public bool InCart { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("estimated_weight")]
        public int EstimatedWeight { get; set; }

        [JsonProperty("format_quantity")]
        public int FormatQuantity { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}