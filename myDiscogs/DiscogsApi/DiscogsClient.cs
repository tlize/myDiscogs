using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace myDiscogs.DiscogsApi
{
    public class DiscogsClient : HttpClient
    {
        public async Task<string> GetCollectionValueAsync()
        {
            var result = await GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/collection/value");
            return result.ToString();
        }

        public async Task<string> GetCollectionAsync()
        {
            return await GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/collection/folders/1/releases");
        }

        public async Task<string> GetInventoryAsync()
        {
            return await GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/inventory");
        }

        public async Task<string> GetWantListAsync()
        {
            return await GetDiscogsData("users/" + DiscogsAuth.USER_NAME + "/wants");
        }

        public async Task<string> GetOrdersAsync()
        {
            return await GetDiscogsData("marketplace/orders");
        }


        private async Task<string> GetDiscogsData(string endpoint)
        {
            using (DiscogsClient client = new DiscogsClient
            {
                BaseAddress = new Uri("https://api.discogs.com/")
            })
            {
                var timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();

                var random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var nonce = new string(
                    Enumerable.Repeat(chars, 25).Select(
                        s => s[random.Next(s.Length)]
                        ).ToArray());

                client.DefaultRequestHeaders.Add("Authorization",
                    "OAuth oauth_consumer_key=\"" + DiscogsAuth.CONSUMER_KEY
                    + "\",oauth_token=\"" + DiscogsAuth.TOKEN
                    + "\",oauth_signature_method=\"PLAINTEXT\",oauth_timestamp=\"" + timestamp
                    + "\",oauth_nonce=\"" + nonce
                    + "\",oauth_version=\"1.0\",oauth_signature=\"" + DiscogsAuth.CONSUMER_SECRET + "%26" + DiscogsAuth.TOKEN_SECRET + "\""
                    );
                client.DefaultRequestHeaders.Add("User-Agent", DiscogsAuth.USER_AGENT);

                var data = String.Empty;

                HttpResponseMessage response = await client.GetAsync(endpoint);
                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync();
                }
                return data;
            }
        }


        public DiscogsClient() { }
    }
}