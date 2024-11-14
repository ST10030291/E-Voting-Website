using System.ComponentModel.DataAnnotations;

namespace E_Voting_Application.Models
{
    public class Vote
    {
        public string Id { get; set; }
        [Required]
        public string VoterId { get; set; }
        [Required]
        public string PartyId { get; set; }
        [Required]
        public string Province { get; set; } 
        public DateTime DateCast { get; set; }
    }
}
