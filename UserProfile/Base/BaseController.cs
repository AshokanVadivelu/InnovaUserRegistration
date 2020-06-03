using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UserProfile.Handler;

namespace UserProfile.Base
{
    public class BaseController : Controller
    {

        protected async System.Threading.Tasks.Task<HttpResponseMessage> PostAsync<TRequest, TResponse>(string name, TRequest request)
        {
            return await RequestHandler.Instance.PostAsync<TRequest>( GetConfigValue(name), request);
        }

        private string GetConfigValue(string key)
        {
            var configValue = ConfigurationManager.AppSettings[key];
            return string.IsNullOrEmpty(configValue) ? "" : configValue;
        }

        protected void SetUserID<T>(T userId)
        {
            Session["User"] = userId;
        }
        protected T GetUserID<T>()
        {
          return  (T) Session["User"];
        }
    }
}