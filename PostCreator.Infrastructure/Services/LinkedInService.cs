using Newtonsoft.Json;
using PostCreator.Core.Services;
using System.Text;
using static PostCreator.Core.Models;

namespace PostCreator.Infrastructure.Services
{
    public class LinkedInService : ILinkedInService
    {
        private readonly HttpClient _httpClient;

        public LinkedInService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<bool> PostToLinkedInAsync(string accessToken, Article content)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _httpClient.PostAsync("https://api.linkedin.com/v2/ugcPosts",
                new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"));

            return response.IsSuccessStatusCode;
        }
    }

}
