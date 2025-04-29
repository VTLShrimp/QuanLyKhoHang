using Microsoft.AspNetCore.Mvc;

namespace QuanLyKhoHang.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
