using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Subscription
{
    public class DeleteSubscriptionDTO
    {
        public int SubscriptionID { get; set; }
        public bool IsActive { get; set; }
   
    }
}
