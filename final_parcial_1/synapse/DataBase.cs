using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using synapse.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public class DataBase
    {
        public static void createUser(String user, String email, String pass) {

            var json = JsonConvert.SerializeObject(new
            {
                name = user,
                email = email,
                pass = pass
            });

            var res = WebRequest.CreateHttp("https://top-yotutube-music.firebaseio.com/users/.json");
            res.Method = "POST";
            res.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            res.ContentLength = buffer.Length;
            res.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = res.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }

        public void verefielAuth(String email, String pass)
        {

            var json = JsonConvert.SerializeObject(new
            {
                email = email,
                pass = pass
            });

            var res = WebRequest.CreateHttp("https://top-yotutube-music.firebaseio.com/.json");
            res.Method = "POST";
            res.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            res.ContentLength = buffer.Length;
            res.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = res.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }




        public class User
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Pass { get; set; }
            public string Email { get; set; }
        }

        public static bool SignIn(String user, String pass) { 
            
        var res = new WebClient().DownloadString("https://top-yotutube-music.firebaseio.com/users.json");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res);
            //var list = new List<User>();
            foreach (var itemDynamic in data)
            {
                //list.Add(JsonConvert.DeserializeObject<User>(((JProperty)itemDynamic).Value.ToString()));
                var userGetting = (JsonConvert.DeserializeObject<User>(((JProperty)itemDynamic).Value.ToString()));
                if (userGetting.Name == user || userGetting.Email == user  ) {
                    if (userGetting.Pass == pass)
                    {
                        Settings.Default.Email = userGetting.Email;
                        Settings.Default.Save();
                        return true;
                    }
                }
            }
            return false;
            
        }

        internal static bool registerUser(string user, string pass, string email)
        {
            var res = new WebClient().DownloadString("https://top-yotutube-music.firebaseio.com/users.json");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(res);
            //var list = new List<User>();
            foreach (var itemDynamic in data)
            {
                //list.Add(JsonConvert.DeserializeObject<User>(((JProperty)itemDynamic).Value.ToString()));
                var userGetting = (JsonConvert.DeserializeObject<User>(((JProperty)itemDynamic).Value.ToString()));
                if (userGetting.Name == user || userGetting.Email == email || userGetting.Name == email || userGetting.Email == user)
                {
                    return true;
                }
            }
            // No
            createUser(user, email, pass);
            return false;
        }
    }
}
