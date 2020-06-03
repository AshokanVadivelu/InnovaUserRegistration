using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserService.Helper
{
    public interface ICachHelper
    {
        object GetValue(string key);

        bool Add(string key, object value, DateTimeOffset absExpiration);

        void Delete(string key);
    }
}