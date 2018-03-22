using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using KN.Platform.Authorization;
using KN.Platform.Web.Controllers;

namespace KN.Platform.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}