using AutoMapper;
using DataAccess.DataModel;
using Models.LocationDtos;
using Models.SupplierDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StateDto, State>();

            CreateMap<SupplierDto, Supplier>().ReverseMap();
            CreateMap<CreateSupplierDto, Supplier>().ReverseMap();
            CreateMap<UpdateSupplierDto, Supplier>().ReverseMap();
            CreateMap<SupplierDto, CreateSupplierDto>().ReverseMap();
            CreateMap<SupplierDto, UpdateSupplierDto>().ReverseMap();
        }
    }
}
