using Microsoft.AspNetCore.Mvc;

namespace DotnetExam.Controllers
{
    public class TestArtistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numtimes = 4)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numtimes;

            return View();
        }
    }
}
