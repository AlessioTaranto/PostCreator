using static PostCreator.Core.Models;

namespace PostCreator.Core.Services
{
    public interface ILinkedInService
    {
        Task<bool> PostToLinkedInAsync(string accessToken, Article content);
    }
}
