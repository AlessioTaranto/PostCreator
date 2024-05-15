using Newtonsoft.Json;
using PostCreator.Core.Services;
using System.Text;
using static PostCreator.Core.Records;

namespace PostCreator.Infrastructure.Services
{
    public class OpenAIService : IOpenAIService
    {
        private readonly HttpClient _httpClient;

        public OpenAIService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<string> GenerateTextAsync(string prompt)
        {
            // Implement the call to OpenAI API
            // You'll need to set your API key in the request header
            var response = await _httpClient.PostAsync("Your OpenAI API URL",
                new StringContent(JsonConvert.SerializeObject(new { prompt }), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<OpenAIResponse>(content);
                return result.Text;
            }

            return "Error generating text.";
        }
    }

}
