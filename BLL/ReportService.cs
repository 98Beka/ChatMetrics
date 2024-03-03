using AutoMapper;
using BLL.DTOs;
using DAL.Entities;
using DAL.Repositories;

namespace BLL;

public interface IReportService {
    Task<IEnumerable<TotalChatsReportDto>> GetAllTotalChatsReportsAsync();
    Task<IEnumerable<DurationReportDto>> GetAllDurationReportsAsync();
    Task<IEnumerable<RatingsReportDto>> GetAllRatingsReportsAsync();
    Task<IEnumerable<ResponseTimeReportDto>> GetAllResponseTimeReportsAsync();
}

public class ReportService : IReportService {
    private readonly IRepository<TotalChatsReport> _totalChatsReportRepository;
    private readonly IRepository<DurationReport> _durationReportRepository;
    private readonly IRepository<RatingsReport> _ratingsReportRepository;
    private readonly IRepository<ResponseTimeReport> _responseTimeReportRepository;
    private readonly IMapper _mapper;

    public ReportService(
        IRepository<TotalChatsReport> totalChatsReportRepository,
        IRepository<DurationReport> durationReportRepository,
        IRepository<RatingsReport> ratingsReportRepository,
        IRepository<ResponseTimeReport> responseTimeReportRepository,
        IMapper mapper) {
        _totalChatsReportRepository = totalChatsReportRepository;
        _durationReportRepository = durationReportRepository;
        _ratingsReportRepository = ratingsReportRepository;
        _responseTimeReportRepository = responseTimeReportRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TotalChatsReportDto>> GetAllTotalChatsReportsAsync() {
        var reports = await _totalChatsReportRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<TotalChatsReportDto>>(reports);
    }

    public async Task<IEnumerable<DurationReportDto>> GetAllDurationReportsAsync() {
        var reports = await _durationReportRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<DurationReportDto>>(reports);
    }

    public async Task<IEnumerable<RatingsReportDto>> GetAllRatingsReportsAsync() {
        var reports = await _ratingsReportRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<RatingsReportDto>>(reports);
    }

    public async Task<IEnumerable<ResponseTimeReportDto>> GetAllResponseTimeReportsAsync() {
        var reports = await _responseTimeReportRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<ResponseTimeReportDto>>(reports);
    }
}
