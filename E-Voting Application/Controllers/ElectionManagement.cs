using Microsoft.AspNetCore.Mvc;

namespace E_Voting_Application.Controllers
{
    public class ElectionManagement : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterPartyForm(Models.Party party)
        {
            return View();
        }
    }
}
