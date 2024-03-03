using AutoMapper;
using BLL.DTOs;
using ChatMetrics.Models;
using DAL.Entities;

namespace ChatMetrics;
public class ApplicationMappingProfile : Profile {
    public ApplicationMappingProfile() {
        // Маппинг сущности на DTO
        CreateMap<TotalChatsReport, TotalChatsReportDto>().ReverseMap();

        // Маппинг DTO на View Model
        CreateMap<TotalChatsReportDto, TotalChatsReportViewModel>()
            .ForMember(vm => vm.TotalChats, map => map.MapFrom(dto => dto.Total));
    }
}