using System.ComponentModel.DataAnnotations;

namespace E_Voting_Application.Models
{
    public class Party
    {
        public string Id { get; set; }
        [Required]
        public string PartyName { get; set; }
        [Required]
        public string PartyLeader { get; set; }
        public int ElectionId { get; set; }
        [Required]
        public int VoteCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
