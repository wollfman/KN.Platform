using System.Collections.Generic;
using KN.Platform.Authorization.Users.Dto;
using KN.Platform.Dto;

namespace KN.Platform.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}