using Microsoft.AspNetCore.Mvc;

namespace E_Voting_Application.Controllers
{
    public class ElectionManagement : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddParty()
        {
            return View();
        }

        public IActionResult AddElection()
        {
            return View();
        }

        public IActionResult CastVote()
        {
            return View();
        }

        public IActionResult VotingRules()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPartyForm(Models.Party party)
        {
            return View();
        }

        [HttpPost]
        public IActionResult createElectionForm(Models.Election election)
        {
            return View();
        }
    }
}
