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

        // This action might handle a POST request to finalize the registration after Firebase authentication
        [HttpPost]
        public IActionResult RegisterUserForm(Models.User user)
        {
            if (ModelState.IsValid)
            {
                // Handle any server-side user data processing here (e.g., save user data to your database)
                // Note: You can also save user details to Firebase Firestore if needed at this point.

                return RedirectToAction("Login");
            }

            return View("Register", user); // Re-render the Register view with validation errors
        }
    }
}
