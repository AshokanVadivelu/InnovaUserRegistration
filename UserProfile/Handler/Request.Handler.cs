using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace UserProfile.Handler
{
    public class RequestHandler
    {
        private static readonly string  baseUri = "http://localhost:64295/Help";

        private static RequestHandler instance = null;

        private static readonly object padlock = new object();


        private RequestHandler()
        {
        }

        public static RequestHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new RequestHandler();
                        }
                    }
                }
                return instance;
            }
        }
        public async Task<HttpResponseMessage> PostAsync<TRequest>(string name, TRequest model) 
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    response = await client.PostAsJsonAsync(name, model);
                    //if (res.IsSuccessStatusCode)
                    //{
                    //    response = res.Content.ReadAsAsync<TResponse>().Result;
                    //}                    
                }
               
            }
            catch(Exception ex)
            {
                // Logger.Log(ex.Message.ToString();
            }
            return response;
        }
    }
}
