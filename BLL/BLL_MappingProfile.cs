using AutoMapper;
using BLL.DTOs;
using DAL.Entities;

namespace BLL;
public class BLL_MappingProfile : Profile {
    public BLL_MappingProfile() {
        CreateMap<TotalChatsReport, TotalChatsReportDto>().ReverseMap();

        CreateMap<DurationReport, DurationReportDto>()
            .ForMember(dest => dest.TotalDuration, opt => opt.MapFrom(src => src.TotalDuration));

        CreateMap<RatingsReport, RatingsReportDto>()
            .ForMember(dest => dest.GoodRatings, opt => opt.MapFrom(src => src.Good))
            .ForMember(dest => dest.BadRatings, opt => opt.MapFrom(src => src.Bad));
        CreateMap<ResponseTimeReport, ResponseTimeReportDto>();
    }
}