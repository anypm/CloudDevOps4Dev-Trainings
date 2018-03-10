using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http; 
using Newtonsoft.Json;


namespace aspnet_core_dotnet_core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GetUserList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "DevOps pipeline test";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

       public async void GetUserList()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage res = await client.GetAsync("https://devops-demo-function01.azurewebsites.net/api/UserList?code=L/68fy1gvJIqPSF0eqRbyfUhjZU9j3outxnj7tM0bh77cdipxvuuNg==");
            var list=new List<User>();
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                list=JsonConvert.DeserializeObject<List<User>>(data);
                ViewData["UserList"]=list;
            }
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Phone { get; set; }

    }
}
