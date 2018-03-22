using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using KN.Platform.Web.Areas.Mpa.Models.Common.Modals;
using KN.Platform.Web.Controllers;

namespace KN.Platform.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : AbpZeroTemplateControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}