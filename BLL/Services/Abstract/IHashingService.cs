using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Abstract
{
    public interface IHashingService
    {
        string CreateHash(string stringToHash);
        bool IsStringEqualHash(string stringToHash, string hash);
    }
}
