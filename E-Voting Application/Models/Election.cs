using System.ComponentModel.DataAnnotations;

namespace E_Voting_Application.Models
{
    public class Election
    {
        public string Id { get; set; }
        [Required]
        public string ElectionName { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        // Sub-collection in the firebase 
        public List<Party> Parties { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
