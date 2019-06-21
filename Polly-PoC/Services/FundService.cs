using Polly_PoC.Clients;
using Polly_PoC.Domain.Models;
using Polly_PoC.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polly_PoC.Services
{
    public class FundService : IFundService
    {
        private readonly IFundClient _fundClient;

        public FundService(IFundClient fundClient)
        {
            _fundClient = fundClient;
        }

        public async Task<IEnumerable<Fund>> ListAsync()
        {
            var funds = await _fundClient.ListAsync();

            return funds;
        }
        public async Task<Fund> GetAsync(int id)
        {
            var fund = await _fundClient.GetAsync(id);

            return fund;
        }
    }
}
