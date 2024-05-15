using PostCreator.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostCreator.Core.Models;

namespace PostCreator.Infrastructure.Services
{
    public class ArticleService : IArticleService
    {
        public List<Article> Articles { get; private set; } = new List<Article>();

        public async Task LoadArticles(string prompt)
        {
            // Simulate a delay for loading
            await Task.Delay(2000);
            Articles = new List<Article> {
                new Article ("Generated Article 1", "Subtitle of the first article..."),
                new Article ("Generated Article 2", "Subtitle of the second article..."),
                new Article ("Generated Article 3", "Subtitle of the third article...")
            };
        }
    }
}
