using Microsoft.AspNetCore.Mvc;

namespace ASPBookProject.Controllers
{
    public class DashBoard : Controller
    {
        // GET: DashBoard
        public ActionResult Index()
        {
            return View();
        }

    }
}
