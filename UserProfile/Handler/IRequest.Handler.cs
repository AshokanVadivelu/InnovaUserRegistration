using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProfile.Handler
{
    public interface IRequestHandler
    {
         Task<R> PostAsync<T,R>(string name, T content);
    }
}
