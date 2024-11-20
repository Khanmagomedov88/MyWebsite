using Microsoft.AspNetCore.Mvc;
using WebsiteKh.Models;

namespace WebsiteKh.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Con()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
