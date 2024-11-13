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
        [Required]
        public string JurisdictionLevel { get; set;} // Either national, provincial or both. 
        [Required]
        public int VoteCount { get; set; }
        [Required]
        public string PartyImageUrl { get; set; }
        [Required]
        public string LeaderImageUrl { get; set; }
    }
}
