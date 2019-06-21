using AutoMapper;
using Polly_PoC.Domain.Models;
using Polly_PoC.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polly_PoC.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Fund, FundResource>();
        }
    }
}
