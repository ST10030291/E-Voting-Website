using System.ComponentModel.DataAnnotations;

namespace E_Voting_Application.Models
{
    public class Election
    {
        [Required]
        public string ElectionName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public List<string> PartyIds { get; set; } 
    }

}
