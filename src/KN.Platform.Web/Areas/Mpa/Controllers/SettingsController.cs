﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Runtime.Session;
using Abp.Timing;
using Abp.Web.Mvc.Authorization;
using KN.Platform.Authorization;
using KN.Platform.Configuration.Tenants;
using KN.Platform.Timing;
using KN.Platform.Timing.Dto;
using KN.Platform.Web.Areas.Mpa.Models.Settings;
using KN.Platform.Web.Controllers;

namespace KN.Platform.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_Settings)]
    public class SettingsController : AbpZeroTemplateControllerBase
    {
        private readonly ITenantSettingsAppService _tenantSettingsAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ITimingAppService _timingAppService;

        public SettingsController(
            ITenantSettingsAppService tenantSettingsAppService,
            IMultiTenancyConfig multiTenancyConfig,
            ITimingAppService timingAppService)
        {
            _tenantSettingsAppService = tenantSettingsAppService;
            _multiTenancyConfig = multiTenancyConfig;
            _timingAppService = timingAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantSettingsAppService.GetAllSettings();
            ViewBag.IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled;

            var timezoneItems = await _timingAppService.GetTimezoneComboboxItems(new GetTimezoneComboboxItemsInput
            {
                DefaultTimezoneScope = SettingScopes.Tenant,
                SelectedTimezoneId = await SettingManager.GetSettingValueForTenantAsync(TimingSettingNames.TimeZone, AbpSession.GetTenantId())
            });

            var model = new SettingsViewModel
            {
                Settings = output,
                TimezoneItems = timezoneItems
            };

            return View(model);
        }
    }
}