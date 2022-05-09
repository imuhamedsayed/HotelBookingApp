using BookingSystem.BLL.RepositoryWeb.IRepository;
using BookingSystem.BLL.ViewModels;
using BookingSystem.DAL;
using BookingSystem.DAL.DatabaseContext;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BookingSystem.BLL.RepositoryWeb
{
    public class BranchRepository : IBranchRepository
    {

        private readonly IHttpClientFactory _clientFactory;

        public BranchRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Branch>> Get(string url, string token = "")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _clientFactory.CreateClient();
            if (token != null && token.Length != 0)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Branch>>(jsonString);
            }
            return null;
        }

        public async Task<Branch> GetById(int id, string url, string token = "")
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
                return JsonConvert.DeserializeObject<Branch>(jsonString);
            }
            return null;
        }
    }
}