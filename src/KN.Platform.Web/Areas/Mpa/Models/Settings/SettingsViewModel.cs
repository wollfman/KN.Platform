﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using KN.Platform.Configuration.Tenants.Dto;

namespace KN.Platform.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}