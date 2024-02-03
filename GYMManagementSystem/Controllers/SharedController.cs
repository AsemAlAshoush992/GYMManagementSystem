using GYMManagementSystem.Context;
using GYMManagementSystem.DTOs.Admin.Person;
using GYMManagementSystem.DTOs.Client;
using GYMManagementSystem.Interfaces;
using GYMManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase, IShared
    {
        private readonly GYMManagementSystemDbContext _context;
        public SharedController(GYMManagementSystemDbContext context)
        {
            _context = context;
        }
        #region Action
        /// <summary>
        /// Retrieve all Coaches in GYM.
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCoachesAction()
        {

            
            try
            {
                return Ok(await GetAllCoaches());
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Retrieve all Subscriptions in GYM.
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllSubscriptionsAction()
        {
            try
            {
                return Ok(await GetAllSubscriptions());
            }
            catch (Exception ex)
            {

                throw new Exception("Test Exception");
            }
        }
        /// <summary>
        /// Retrieve all Subscriptions by price, MemberType and duration in days Clients in GYM.
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FillteringSubscriptionsAction(float? price, int? type, int? duration)
        {
            try
            {
                return Ok(await FillteringSubscriptions(price, type, duration));
            }
            catch (Exception ex)
            {

                throw new Exception("Test Exception");
            }
        }
        /// <summary>
        /// Create New Account for Clients in GYM.
        /// </summary>
        /// <response code="201">A new account has been created</response>
        /// <response code="400">Somthing went wrong</response>  
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {        
        ///         "fullName": "yaser jamal",
        ///         "email": "yaser.jamal@haoo.com",
        ///         "phoneNumber": "00962799688556",
        ///         "nationalID": "4569789781",
        ///         "passWord": "47893652",
        ///         "birthDate": "2024-02-01T17:46:54.018Z",
        ///         "genderType": "Male",
        ///         "Image": "asem"
        ///         "age": 33,
        ///         "height": 177,
        ///         "weight": 80,
        ///         "healthStatus": "Uninfected"        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewAccountAction([FromForm] CreateClientDTO dto)
        {
            try
            {
                await CreateNewAccount(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "A new account has been created" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed create Account {ex.Message}" };

            }
        }
        /// <summary>
        /// Login in the Account for Clients in GYM.
        /// </summary>
        /// <response code="201">You have successfully logged into the account</response>
        /// <response code="401">The client is not authorized to enter</response> 
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {        
        ///       "email": "Mohammed@yahoo.com",
        ///       "phoneNumber": "00962795747446",
        ///       "passWord": "59746329"        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginAction(LoginDTO dto)
        {
            try
            {
                await Login(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Sign in successful" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Sign in failed {ex.Message}" };

            }
        }
        
        #endregion
        #region Implementation
        [NonAction]
        public async Task<List<GetAllCoachesDTO>> GetAllCoaches()
        {
            var query2 = await _context.People
                .Where(x => (int)x.personType == 3 && x.IsActive == true).ToListAsync();
            List<GetAllCoachesDTO> Coaches = new List<GetAllCoachesDTO>();
            foreach (var item in query2)
            {
                GetAllCoachesDTO temp = new GetAllCoachesDTO();
                temp.FullName = item.FullName;
                temp.Email = item.Email;
                temp.PhoneNumber = item.PhoneNumber;
                temp.Certifications = item.Certifications;
                temp.genderType = item.genderType.ToString();
                temp.Specialization = item.Specialization;
                Coaches.Add(temp);
            }

            return Coaches;
        }
        [NonAction]
        public async Task<List<GetAllSubscriptionsDTO>> GetAllSubscriptions()
        {
            var query1 = await _context.Subscriptions.Where(x => x.IsActive == true).ToListAsync();
            List<GetAllSubscriptionsDTO> Subscription = new List<GetAllSubscriptionsDTO>();
            foreach (var item in query1)
            {
                GetAllSubscriptionsDTO temp = new GetAllSubscriptionsDTO();
                temp.Description = item.Description;
                temp.Price = item.Price;
                temp.TrainingHoursInDay = item.TrainingHoursInDay;
                temp.DurationInDays = item.DurationInDays;
                temp.MaxNumberOfVisits = item.MaxNumberOfVisits;
                temp.Type = item.Type.ToString();
                Subscription.Add(temp);
            }

            return Subscription;
        }
        [NonAction]
        public async Task CreateNewAccount( CreateClientDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email))
                throw new Exception("Email is Required");
            if (string.IsNullOrEmpty(dto.PhoneNumber))
                throw new Exception("PhoneNumber is Required");
            if (string.IsNullOrEmpty(dto.NationalID))
                throw new Exception("NationalID is Required");
            if (string.IsNullOrEmpty(dto.FullName))
                throw new Exception("FullName is Required");
            if (string.IsNullOrEmpty(dto.PassWord))
                throw new Exception("PassWord is Required");
            using var dataStream = new MemoryStream();
            await dto.Image.CopyToAsync(dataStream);

            Person client = new Person();
            client.FullName = dto.FullName;
            client.PhoneNumber = dto.PhoneNumber;
            client.Email = dto.Email;
            client.NationalID = dto.NationalID;
            client.PassWord = dto.PassWord;
            client.BirthDate = dto.BirthDate;
            client.HealthStatus = dto.HealthStatus;
            client.Height = dto.Height;
            client.Weight = dto.Weight;
            client.Age = dto.Age;
            client.Image = dataStream.ToArray();
            client.personType = (PersonType)Enum.ToObject(typeof(PersonType), 2);
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), dto.genderType);
            int intgender = (int)gender;
            client.genderType = (GenderType)Enum.ToObject(typeof(GenderType), intgender);
            await _context.AddAsync(client);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task Login(LoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.PassWord))
                throw new Exception("Email or Phone Number and Password are Required");
            var login = await _context.People
                .Where(x => x.Email.Equals(dto.Email) || x.PhoneNumber.Equals(dto.PhoneNumber) && x.PassWord.Equals(dto.PassWord))
                .SingleOrDefaultAsync();
            if (login == null)
            {
                throw new Exception("Email or Phone Number and Password are not correct");
            }
        }
        [NonAction]
        public async Task<List<GetAllSubscriptionsDTO>> FillteringSubscriptions(float? price, int? type, int? duration)
        {
            bool flag = price == null && type == null && duration == null?true:false;

            //var query1 = await _context.Subscriptions
            //    .Where(x => x.Price == price || x.DurationInDays == duration || (int)x.Type == (int)type 
            //    || flag)
            //    .ToListAsync();
            var query1 = from c in _context.Subscriptions
                where c.Price >= price || c.DurationInDays >= duration || (int)c.Type == type || flag

                         select c;
            List<GetAllSubscriptionsDTO> Subscription = new List<GetAllSubscriptionsDTO>();
            foreach (var item in query1)
            {
                GetAllSubscriptionsDTO temp = new GetAllSubscriptionsDTO();
                temp.Description = item.Description;
                temp.Price = item.Price;
                temp.TrainingHoursInDay = item.TrainingHoursInDay;
                temp.DurationInDays = item.DurationInDays;
                temp.MaxNumberOfVisits = item.MaxNumberOfVisits;
                temp.Type = item.Type.ToString();
                Subscription.Add(temp);
            }
            return Subscription;
        }
        #endregion
    }
}
