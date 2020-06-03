using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserProfile.Base;
using UserProfile.Models;

namespace UserProfile.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //var response = Task.Run(() => PostAsync<string, RegisterViewModel>("UserInfo", GetUserID())).Result;
            //var responseContent =  response.Content.ReadAsStringAsync().Result;
            //var user = JsonConvert.DeserializeObject<RegisterViewModel>(responseContent);
            return View(GetUserID<RegisterViewModel>());
        }

        public ActionResult SubmitUser(RegisterViewModel model)
        {
            return  Json(Task.Run(() => PostAsync<RegisterViewModel, string>("SubmitUser", model)).Result);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}