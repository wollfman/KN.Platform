using System.Collections.Generic;
using KN.Platform.Caching.Dto;

namespace KN.Platform.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}