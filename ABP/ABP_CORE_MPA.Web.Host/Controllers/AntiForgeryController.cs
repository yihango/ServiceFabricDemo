using Microsoft.AspNetCore.Antiforgery;
using ABP_CORE_MPA.Controllers;

namespace ABP_CORE_MPA.Web.Host.Controllers
{
    public class AntiForgeryController : ABP_CORE_MPAControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
