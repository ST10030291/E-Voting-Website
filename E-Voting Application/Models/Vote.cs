namespace E_Voting_Application.Models
{
    public class Vote
    {
        public string UserId { get; set; } 
        public string PartyId { get; set; } 
        public string ElectionId { get; set; } 
        public DateTime Timestamp { get; set; } 
    }
}
