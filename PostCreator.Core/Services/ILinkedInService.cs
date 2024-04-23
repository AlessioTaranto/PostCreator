using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostCreator.Core.Records;

namespace PostCreator.Core.Services
{
    public interface ILinkedInService
    {
        Task<bool> PostToLinkedInAsync(string accessToken, Article content);
    }
}
