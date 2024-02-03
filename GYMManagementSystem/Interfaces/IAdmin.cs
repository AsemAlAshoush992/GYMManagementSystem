using GYMManagementSystem.DTOs.Admin.Department;
using GYMManagementSystem.DTOs.Admin.Person;
using GYMManagementSystem.DTOs.Admin.Subscription;
using GYMManagementSystem.DTOs.Client;

namespace GYMManagementSystem.Interfaces
{
    public interface IAdmin
    {
        //Manage Employees and Coaches
        Task CreateCoachEmployee(CreateCoachEmployeeDTO dto);
        Task UpdateCoachEmployee(UpdateCoachEmployeeDTO dto);
        Task DeleteCoachEmployee(DeleteCoachEmployeeDTO dto);
        //Manage Admins
        Task CreateNewAdmin(CreateCoachEmployeeDTO dto);
        Task UpdateAdminِAccount(UpdateAdminDTO dto);
        Task LoginAdmin(LoginDTO dto);
        //Manage Clients
        //Manage Departments
        Task CreateNewDepartment(CreateDepartmentDTO dto);
        Task UpdateDepartment(UpdateDepartmentDTO dto);
        Task DeleteDepartment(DeleteDepartmentDTO dto);
        //Manage Subscriptions
        Task CreateNewSubscription(CreateSubscriptionDTO dto);
        Task UpdateSubscription(UpdateSubscriptionDTO dto);
        Task DeleteSubscription(DeleteSubscriptionDTO dto);
    }
}
