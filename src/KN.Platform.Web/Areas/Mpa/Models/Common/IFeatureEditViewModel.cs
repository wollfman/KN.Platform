using System.Collections.Generic;
using Abp.Application.Services.Dto;
using KN.Platform.Editions.Dto;

namespace KN.Platform.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}