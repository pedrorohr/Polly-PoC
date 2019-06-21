using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Polly_PoC.Domain.Models;
using Polly_PoC.Domain.Services;
using Polly_PoC.Resources;

namespace Polly_PoC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {

        private readonly IFundService _fundService;
        private readonly IMapper _mapper;

        public FundsController(IFundService fundService, IMapper mapper)
        {
            _fundService = fundService;
            _mapper = mapper;
        }

        // GET api/funds
        [HttpGet]
        public async Task<IEnumerable<FundResource>> Get()
        {
            var funds = await _fundService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Fund>, IEnumerable<FundResource>>(funds);

            return resources;
        }

        // GET api/funds/5
        [HttpGet("{id}")]
        public async Task<FundResource> Get(int id)
        {
            var fund = await _fundService.GetAsync(id);
            var resource = _mapper.Map<Fund, FundResource>(fund);
            return resource;
        }
    }
}
