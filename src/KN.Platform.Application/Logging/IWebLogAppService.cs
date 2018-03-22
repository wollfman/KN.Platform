using Abp.Application.Services;
using KN.Platform.Dto;
using KN.Platform.Logging.Dto;

namespace KN.Platform.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
