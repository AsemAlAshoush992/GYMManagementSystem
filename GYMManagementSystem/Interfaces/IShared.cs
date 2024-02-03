using GYMManagementSystem.DTOs.Admin.Person;
using GYMManagementSystem.DTOs.Client;

namespace GYMManagementSystem.Interfaces
{
    public interface IShared
    {
        //Get All Coaches
        Task<List<GetAllCoachesDTO>> GetAllCoaches();
        //Get All Subscriptions
        Task<List<GetAllSubscriptionsDTO>> GetAllSubscriptions();
        //Filltering Subscriptions By price, duration in date and Type 
        Task<List<GetAllSubscriptionsDTO>> FillteringSubscriptions( float? price, int? type, int? duration);
        //Create New Account
        Task CreateNewAccount(CreateClientDTO dto);
        //Login In Account
        Task Login(LoginDTO dto);
    }
}
