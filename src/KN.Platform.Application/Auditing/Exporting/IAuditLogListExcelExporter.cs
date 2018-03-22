using System.Collections.Generic;
using KN.Platform.Auditing.Dto;
using KN.Platform.Dto;

namespace KN.Platform.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
