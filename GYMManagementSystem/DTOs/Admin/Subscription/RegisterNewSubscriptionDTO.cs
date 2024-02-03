namespace GYMManagementSystem.DTOs.Admin.Subscription
{
    public class RegisterNewSubscriptionDTO
    {
        public int SubscriptionID { get; set; }
        public int ClientID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
