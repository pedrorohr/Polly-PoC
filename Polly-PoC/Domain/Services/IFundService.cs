using Polly_PoC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polly_PoC.Domain.Services
{
    public interface IFundService
    {
        Task<IEnumerable<Fund>> ListAsync();
        Task<Fund> GetAsync(int id);
    }
}
