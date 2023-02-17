using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Gitlab
{
    internal class ApiRequest
    {
        public Token getToken(string username, string password)
        {
            using (var httpClient = new HttpClient())
            {

                var req= new HttpRequestMessage(HttpMethod.Post, $"https://gitlab.com/oauth/token?grant_type=password&username={username}&password={password}");
                var res = httpClient.SendAsync(req).Result;
                var resContent = res.Content.ReadAsStringAsync().Result;

                var authentication = JsonConvert.DeserializeObject<Token>(resContent);

                return authentication;
            }
        }

        public List<Issues> getIssues(string Token)
        {
            using (var httpClient = new HttpClient())
            {
                var req = new HttpRequestMessage(HttpMethod.Get, $"https://gitlab.com/api/v4/projects/43607636/issues?scope=all&access_token={Token}");
                var res = httpClient.SendAsync(req).Result;
                var resContent = res.Content.ReadAsStringAsync().Result;

                var issuesInfo = JsonConvert.DeserializeObject<List<Issues>>(resContent);

                return issuesInfo;
            }
        }


        public List<Notes> GetNotes(string id, string token)
        {
            using (var httpClient = new HttpClient())
            {
                var req = new HttpRequestMessage(HttpMethod.Get, $"https://gitlab.com/api/v4/projects/43607636/issues/{id}/notes?access_token={token}");
                var res = httpClient.SendAsync(req).Result;
                var resContent = res.Content.ReadAsStringAsync().Result;

                var notesInfo = JsonConvert.DeserializeObject<List<Notes>>(resContent);

                return notesInfo;
            }
        }


        public void AddNote(string id, string Text, string token)
        {
            using (var httpClient = new HttpClient())
            {
                var req = new HttpRequestMessage(HttpMethod.Post, $"https://gitlab.com/api/v4/projects/43607636/issues/{id}/notes?access_token={token}&body={Text}");
                var res = httpClient.SendAsync(req).Result;
            }
        }



    }
}
