using newapp.Domin;
using newapp.Extensions;
using newapp.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newapp.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoriesResponse>();
            CreateMap<Product, ProductResource>()
               .ForMember(src => src.UnitOfMeasurement,
                          opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
