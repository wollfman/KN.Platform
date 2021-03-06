﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using KN.Platform.Configuration.Host.Dto;

namespace KN.Platform.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}