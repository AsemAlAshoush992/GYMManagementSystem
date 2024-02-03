using GYMManagementSystem.DTOs.Admin.Subscription;

namespace GYMManagementSystem.Interfaces
{
    public interface IClient
    {
        //Register in specific subscription 
        Task RegisterSubscription(RegisterNewSubscriptionDTO dto);
    }
}
