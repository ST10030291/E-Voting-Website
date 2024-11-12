using System.ComponentModel.DataAnnotations;

namespace E_Voting_Application.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int IdNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Password and confirmation do not match.")]
        public string PasswordConfirmation { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Role { get; set; } // Admin or Voter
        public string VoterId { get; set; }
        public string VotedInElectionId { get; set; }
    }
}
