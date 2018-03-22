using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using KN.Platform.Auditing.Dto;
using KN.Platform.Dto;

namespace KN.Platform.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}