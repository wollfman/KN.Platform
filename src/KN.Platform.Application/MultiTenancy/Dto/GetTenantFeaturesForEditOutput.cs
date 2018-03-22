using System.Collections.Generic;
using Abp.Application.Services.Dto;
using KN.Platform.Editions.Dto;

namespace KN.Platform.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}