using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using KN.Platform.Authorization;
using KN.Platform.Web.Controllers;

namespace KN.Platform.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}