using Abp.AutoMapper;
using KN.Platform.MultiTenancy;
using KN.Platform.MultiTenancy.Dto;
using KN.Platform.Web.Areas.Mpa.Models.Common;

namespace KN.Platform.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}