namespace MWiseEndpoint
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class MWiseHttpClient
    {
        public HttpClient CreateClient()
        {
            var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10), BaseAddress = new Uri("https://vomars2s-demo.m-point.eu/api/") };

            client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
            return client;
        }
    }
}
