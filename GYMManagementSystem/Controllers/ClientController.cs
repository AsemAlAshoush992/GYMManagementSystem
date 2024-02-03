using GYMManagementSystem.Context;
using GYMManagementSystem.DTOs.Admin.Subscription;
using GYMManagementSystem.Interfaces;
using GYMManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GYMManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase, IClient
    {
        private readonly GYMManagementSystemDbContext _context;
        public ClientController(GYMManagementSystemDbContext context)
        {
            _context = context;
        }
        #region Action
        /// <summary>
        /// Registering for a new subscription in GYM.
        /// </summary>
        /// <response code="201">A new subscription has been registered</response>
        /// <response code="400">Somthing went wrong</response> 
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {        
        ///       "subscriptionID": 3,
        ///       "clientID": 12,
        ///       "startDate": "2024-02-02T06:13:01.620Z",
        ///       "endDate": "2024-02-24T06:13:01.620Z"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> RegisterSubscriptionAction(RegisterNewSubscriptionDTO dto)
        {
            try
            {
                await RegisterSubscription(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "RegisterSubscriptionAction" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed RegisterSubscriptionAction  {ex.Message}" };
            }
        }
        #endregion
        #region Implement
        [NonAction]
        public async Task RegisterSubscription(RegisterNewSubscriptionDTO dto)
        {
            var client1 = await _context.People.FindAsync(dto.ClientID);
            client1.Subscription = await _context.Subscriptions.FindAsync(dto.SubscriptionID);
            client1.StartDate = dto.StartDate;
            client1.EndDate = dto.EndDate;
            _context.Update(client1);
            await _context.SaveChangesAsync();

        }
        #endregion
    }
}
