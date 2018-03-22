using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using KN.Platform.Web.Controllers;

namespace KN.Platform.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}