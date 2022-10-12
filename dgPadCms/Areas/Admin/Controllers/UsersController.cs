using dgPadCms.Infrastructure;
using dgPadCms.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace dgPadCms.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly dgPadCmsContext context;

        public UsersController(UserManager<AppUser> userManager, dgPadCmsContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public IActionResult Delete(string userId)
        {
            var user = context.Users.Find(userId);
            if (user == null) return NotFound();
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
