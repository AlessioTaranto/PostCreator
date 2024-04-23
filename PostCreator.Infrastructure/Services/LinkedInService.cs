using Newtonsoft.Json;
using PostCreator.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static PostCreator.Core.Records;

namespace PostCreator.Infrastructure.Services
{
    public class LinkedInService : ILinkedInService
    {
        private readonly HttpClient _httpClient;

        public LinkedInService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<bool> PostToLinkedInAsync(string accessToken, LinkedInPostContent content)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _httpClient.PostAsync("https://api.linkedin.com/v2/ugcPosts",
                new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }
    }

}
