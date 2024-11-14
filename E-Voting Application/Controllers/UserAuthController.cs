using Microsoft.AspNetCore.Mvc;
using E_Voting_Application.Models;
using Firebase.Auth;

namespace E_Voting_Application.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUserForm(Models.User user)
        {
            return View();
        }
    }
}
