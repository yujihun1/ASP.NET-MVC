using System.Diagnostics;
using Hello.BLL;
using Hello.MVC6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hello.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserBll _userBll;

      


        public HomeController(ILogger<HomeController> logger, UserBll userBll)
        {
            _logger = logger;
            _userBll = userBll;
        }

        public IActionResult Index()
        {
            var userList = _userBll.GetUserList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
