using BookingApp.DataAccess.RepositoryWeb.IRepository;
using BookingSystem.BLL.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BookingApp.DataAccess.RepositoryWeb
{
    public class HotelRepository : IHotelRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public HotelRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Hotel>> GetAllHotels(string url, string token = "")
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
                return JsonConvert.DeserializeObject<IEnumerable<Hotel>>(jsonString);
            }

            return null;
        }
    }
}
