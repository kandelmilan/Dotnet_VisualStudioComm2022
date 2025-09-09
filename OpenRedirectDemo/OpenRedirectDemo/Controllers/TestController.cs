using Microsoft.AspNetCore.Mvc;

namespace OpenRedirectDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index() => Content("Index");
        public IActionResult Create() => Content("Create");
        public IActionResult Exception() => Content("Exception");
        public IActionResult Error() => Content("Error");

        // Example of unsafe redirect
        public IActionResult GoLocalRedirect(string url)
            => LocalRedirect(url);

        // Safer redirect with validation
        public IActionResult GoIsLocalUrl(string url)
        {
            if (Url.IsLocalUrl(url))
                return Redirect(url);
            else
                return RedirectToAction("Error", "Home");
        }
    }
}
