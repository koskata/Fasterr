using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fasterr.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
