using ComandaZap.Services;
using ComandaZap.Services.Commands;
using ComandaZap.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComandaZap.Controllers
{
    public class UserController: Controller
    {
        public UserController()
        {

        }
        [HttpGet]
        public IActionResult Index([FromServices] GetAllUsersCommand service)
        {
            var users = service.Handle().Result;
            return View(users);
        }
        [HttpPost]
        public IActionResult Delete(string userId,[FromServices] DeleteUserCommand service)
        {
            var result = service.Handle(userId);
            if (result.IsSuccess)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Users", result.Message);
            return View("Index");
        }
    }
}
