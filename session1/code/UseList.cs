using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace FunctionApp1
{
    public static class UserList
    {
        [FunctionName("UserList")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            List<User> users = new List<User>();
            users.Add(new User { Username = "jackyzhou", Phone = "136000000000" });
            users.Add(new User { Username = "leixu", Phone = "186000000000" });


            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(users), Encoding.UTF8, "application/json")
            };
        }

        public class User
        {
            public string Username { get; set; }
            public string Phone { get; set; }

        }
    }
}