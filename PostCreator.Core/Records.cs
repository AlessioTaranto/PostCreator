using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCreator.Core
{
    public class Records
    {
        public record Article(string Title, string PostText);
        public record OpenAIResponse(string Text);
    }
}
