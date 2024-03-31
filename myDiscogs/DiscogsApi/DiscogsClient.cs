﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;

namespace myDiscogs.DiscogsApi
{
    public class DiscogsClient : HttpClient
    {
        public string GetCollectionValue()
        {
            return GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/collection/value");
        }

        public string GetWantList(int page)
        {
            return GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/wants?page=" + page);
        }

        public string GetCollection(int page)
        {
            return GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/collection/folders/1/releases?sort=added&sort_order=desc&page=" + page);
        }
        
        public string GetItemsForSale(int page)
        {
            return GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/inventory?status=For Sale&sort=price&sort_order=desc&page=" + page);
        }

        public string GetSoldItems(int page)
        {
            return GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/inventory?status=Sold&sort=price&sort_order=desc&page=" + page);
        }

        public string GetOrders(int page)
        {
            return GetDiscogsData("marketplace/orders?sort=created&sort_order=desc&page=" + page);
        }

        public string GetDiscogsData(string endpoint)
        {
            BaseAddress = new Uri("https://api.discogs.com/");
            SetDiscogsAuthHeaders();

            var response = GetAsync(endpoint).Result;
            string result = response.Content.ReadAsStringAsync().Result;
            return result;
        }

        private string GetNonce()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(
                Enumerable.Repeat(chars, 25).Select(
                    s => s[random.Next(s.Length)]
                    ).ToArray());
        }

        private string GetTimeStamp()
        {
            return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
        }

        private void SetDiscogsAuthHeaders()
        {
            DefaultRequestHeaders.Add("Authorization",
                    "OAuth oauth_consumer_key=\"" + DiscogsAuth.CONSUMER_KEY
                    + "\",oauth_token=\"" + DiscogsAuth.TOKEN
                    + "\",oauth_signature_method=\"PLAINTEXT\",oauth_timestamp=\"" + GetTimeStamp()
                    + "\",oauth_nonce=\"" + GetNonce()
                    + "\",oauth_version=\"1.0\",oauth_signature=\"" + DiscogsAuth.CONSUMER_SECRET + "%26" + DiscogsAuth.TOKEN_SECRET + "\""
                    );
            DefaultRequestHeaders.Add("User-Agent", DiscogsAuth.USER_AGENT);
        }

        public DiscogsClient() { }
    }
}