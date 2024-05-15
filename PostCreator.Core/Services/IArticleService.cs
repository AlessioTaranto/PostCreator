using PostCreator.Core;

namespace PostCreator.Core.Services
{
    public interface IArticleService
    {
        List<Models.Article> Articles { get; }

        Task LoadArticles(string prompt);
    }
}