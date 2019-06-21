using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Polly_PoC.Domain.Models;

namespace Polly_PoC.Clients
{
    public class FundClient : IFundClient
    {
        private readonly HttpClient _httpClient;

        public FundClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("http://localhost:8081/");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Fund>> ListAsync()
        {
            var response = await _httpClient.GetAsync("api/funds");
            response.EnsureSuccessStatusCode();
            var funds = await response.Content.ReadAsAsync<IEnumerable<Fund>>();
            return funds;
        }

        public async Task<Fund> GetAsync(int id)
        {
            var response = await _httpClient.GetAsync("api/funds/" + id);
            response.EnsureSuccessStatusCode();
            var funds = await response.Content.ReadAsAsync<Fund>();
            return funds;
        }
    }
}
