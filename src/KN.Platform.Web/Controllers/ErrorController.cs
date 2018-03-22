using System.Web.Mvc;
using Abp.Auditing;

namespace KN.Platform.Web.Controllers
{
    public class ErrorController : AbpZeroTemplateControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}