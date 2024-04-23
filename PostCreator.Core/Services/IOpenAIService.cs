using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCreator.Core.Services
{
    public interface IOpenAIService
    {
        Task<string> GenerateTextAsync(string prompt);
    }
}
