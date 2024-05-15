namespace PostCreator.Core
{
    public class Models
    {
        public class Article
        {
            public Article(string title, string subtitle)
            {
                Title = title;
                Subtitle = subtitle;
            }

            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string? Text { get; set; }
        }
    }
}
