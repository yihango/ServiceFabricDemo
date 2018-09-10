using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABP_CORE_MPA.Controllers;

namespace ABP_CORE_MPA.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ABP_CORE_MPAControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
