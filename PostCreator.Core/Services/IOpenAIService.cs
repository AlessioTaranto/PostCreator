namespace PostCreator.Core.Services
{
    public interface IOpenAIService
    {
        Task<string> GenerateTextAsync(string prompt);
    }
}
