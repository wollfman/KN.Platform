using System.Collections.Generic;

namespace KN.Platform.Tenants.Dashboard.Dto
{
    public class GetMemberActivityOutput
    {
        public List<int> TotalMembers { get; set; }

        public List<int> NewMembers { get; set; }
    }
}