using BookingSystem.BLL.RepositoryWeb.IRepository;
using BookingSystem.BLL.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.BLL.RepositoryWeb
{
    public class UserRoomRepository : IUserRoomRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public UserRoomRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<bool> AddUserToRoom(UserRooms entity, string url, string token = "")
        {
            if (entity != null)
            {
                var request = new HttpRequestMessage(HttpMethod.Post, url);
                request.Content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
              
                var client = _clientFactory.CreateClient();
                if (token != null && token.Length > 0)
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

       
        public async Task<string> CancelBook(int id, string url, string token = "")
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url + id);

            var client = _clientFactory.CreateClient();
            if (token != null && token.Length != 0)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return "deleted";
          }
            return "not deleted";
        }
        public async Task<IEnumerable<UserRooms>> UserRoom(string id, string url, string token = "")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url + id);

            var client = _clientFactory.CreateClient();
            if (token != null && token.Length != 0)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<UserRooms>>(jsonString);
            }
            return null;
        }

       
    }
}
