using GYMManagementSystem.Context;
using GYMManagementSystem.DTOs.Admin.Department;
using GYMManagementSystem.DTOs.Admin.Person;
using GYMManagementSystem.DTOs.Admin.Subscription;
using GYMManagementSystem.DTOs.Client;
using GYMManagementSystem.Interfaces;
using GYMManagementSystem.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Datatypes;
using System.Reflection;
using static GYMManagementSystem.Helper.Enums.Enums;
using static GYMManagementSystem.Models.Entities.Person;

namespace GYMManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase, IAdmin
    {
        private readonly GYMManagementSystemDbContext _context;
        public AdminController(GYMManagementSystemDbContext context)
        {
            _context = context;
        }
        #region Action
        //department

        /// <summary>
        /// Create a new department in GYM
        /// </summary>
        /// <response code="201">A new department has been created in GYM.</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Department
        ///     {        
        ///       "NameInArabic": "Childcare",
        ///       "NameInEnglish": "رعاية الاطفال",
        ///       "Description": "childcare services so that parents can work out
        ///       without having to worry about their children."        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewDepartmentAction(CreateDepartmentDTO dto)
        {
            try
            {
                await CreateNewDepartment(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "A new Department has been created" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Department Account {ex.Message}" };

            }
        }
        /// <summary>
        /// Update data for the selected department in GYM.
        /// </summary>
        /// <response code="201">Update the selected department </response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Department
        ///     {  
        ///       "departmentID": 5,
        ///       "NameInArabic": "الرجال",
        ///       "NameInEnglish": "for men",
        ///       "Description": "Specialized in all sports matters related to men." 
        ///       "isActive": false,
        ///       "createionDate": "2024-02-05T08:30:59.575Z"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateDepartmentAction(UpdateDepartmentDTO dto)
        {
            try
            {
                await UpdateDepartment(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Department Update successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Update Department Failed  {ex.Message}" };
            }
        }
        /// <summary>
        /// Delete the selected department in GYM.
        /// </summary>
        /// <response code="201">The department has been deleted successfully</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Department
        ///     {  
        ///       "departmentID": 2,
        ///       "isActive": false
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteDepartmentAction(DeleteDepartmentDTO dto)
        {
            try
            {
                await DeleteDepartment(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Department Delete successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Delete Department Failed  {ex.Message}" };
            }
        }

        //Subscriptions
        /// <summary>
        /// Create a new Subscription in GYM.
        /// </summary>
        /// <response code="201"> A new Subscription has been Created in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Subscriptions
        ///     {        
        ///       "  "description": "Strong",
        ///          "type": "VIP",
        ///          "price": 100,
        ///          "durationInDays": 90,
        ///          "trainingHoursInDay": 5,
        ///          "maxNumberOfVisits": 3,       
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewSubscriptionAction(CreateSubscriptionDTO dto)
        {
            try
            {
                await CreateNewSubscription(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "A new Subscription has been created" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Subscription Account {ex.Message}" };

            }
        }
        /// <summary>
        /// Update data for the selected Subscription in GYM.
        /// </summary>
        /// <response code="201">Update the selected Subscription in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Subscription
        ///     {  
        ///         "subscriptionID": 8,
        ///         "description": "Asem",
        ///         "type": "VIP",
        ///         "price": 100,
        ///         "durationInDays": 90,
        ///         "trainingHoursInDay": 5,
        ///         "maxNumberOfVisits": 3,
        ///         "isActive": false,
        ///         "createionDate": "2024-02-12T08:45:18.744Z"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateSubscriptionAction(UpdateSubscriptionDTO dto)
        {
            try
            {
                await UpdateSubscription(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Subscription Update successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Update Subscription Failed  {ex.Message}" };
            }
        }
        /// <summary>
        /// Delete the selected Subscription in GYM.
        /// </summary>
        /// <response code="201">The Subscription has been deleted successfully</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Subscription
        ///    {
        ///        "subscriptionID": 4,
        ///        "isActive": false
        ///    }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSubscriptionAction(DeleteSubscriptionDTO dto)
        {
            try
            {
                await DeleteSubscription(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Subscription Delete successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Delete Subscription Failed  {ex.Message}" };
            }
        }
        //Admin
        /// <summary>
        /// Create a new Admin in GYM.
        /// </summary>
        /// <response code="201"> A new Admin has been Created in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Admin
        ///  {
        ///     "fullName": "Mohammed Saleh",
        ///     "email": "Mohammed@yahoo.com",
        ///     "phoneNumber": "00962799688123",
        ///     "nationalID": "4571389781",
        ///     "passWord": "47836952",
        ///     "birthDate": "2024-02-14T11:53:46.974Z",
        ///     "age": 40,
        ///     "genderType": "Male",
        ///     "personType": "Employee",
        ///     "departmentID": 3,
        ///     "specialization": "Sport",
        ///     "certifications": "Kingboxing",
        ///     "salary": 600
        ///  }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateNewAdminAction(CreateCoachEmployeeDTO dto)
        {
            try
            {
                await CreateNewAdmin(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "A new Adminِ has been created" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Admin Account   {ex.Message}" };

            }
        }
        /// <summary>
        /// Update data for the selected Adminِ in GYM.
        /// </summary>
        /// <response code="201">Update the selected Adminِ in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Admin
        ///  {
        ///     "PersonID": 10
        ///     "fullName": "Mohammed Saleh",
        ///     "password": "12345632"
        ///  }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateAdminِAccountAction(UpdateAdminDTO dto)
        {
            try
            {
                await UpdateAdminِAccount(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Adminِ Update successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Update Adminِ Failed  {ex.Message}" };
            }
        }
        /// <summary>
        /// Login in the Account for Admin in GYM.
        /// </summary>
        /// <response code="201">You have successfully logged into the account</response>
        /// <response code="401">The client is not authorized to enter</response> 
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Admin
        ///     {        
        ///       "email": "Mohammed@yahoo.com",
        ///       "phoneNumber": "00962795747446",
        ///       "passWord": "59746329"        
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> LoginAdminAction(LoginDTO dto)
        {
            try
            {
                await LoginAdmin(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Sign in Admin successful" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Sign in Admin failed {ex.Message}" };

            }
        }
        //Coach and Employee
        /// <summary>
        /// Create a new Coach or Employee in GYM.
        /// </summary>
        /// <response code="201"> A new Coach or Employee has been Created in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Coach or Employee
        ///     {
        ///       "fullName": "Rached",
        ///       "email": "Rached@yahoo.com",
        ///       "phoneNumber": "00962799688197",
        ///       "nationalID": "4121389781",
        ///       "passWord": "47836474",
        ///       "birthDate": "1990-02-20T13:55:48.907Z",
        ///       "age": 33,
        ///       "genderType": "Male",
        ///       "personType": "Coach",
        ///       "departmentID": 5,
        ///       "specialization": "Sport",
        ///       "certifications": "Kingboxing",
        ///       "salary": 600
        ///      }
        /// </remarks>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCoachEmployeeAction(CreateCoachEmployeeDTO dto)
        {
            try
            {
                await CreateCoachEmployee(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "A new Employee and Coach has been created" };
            }
            catch (Exception ex)
            {
                return new ObjectResult(null) { StatusCode = 500, Value = $"Failed Employee and Coach Account   {ex.Message}" };

            }
        }
        /// <summary>
        /// Update data for the selected Coach or Employee in GYM.
        /// </summary>
        /// <response code="201">Update the selected Coach or Employee in GYM</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Coach or Employee
        ///  {
        ///     "PersonID": 10
        ///     "fullName": "Mohammed Saleh",
        ///     "email": "Mohammed@yahoo.com",
        ///     "phoneNumber": "00962799688123",
        ///     "nationalID": "4571389781",
        ///     "passWord": "47836952",
        ///     "birthDate": "1995-02-14T11:53:46.974Z",
        ///     "age": 40,
        ///     "genderType": "Male",
        ///     "personType": "Coach",
        ///     "specialization": "Sport",
        ///     "certifications": "Kingboxing",
        ///     "departmentID": 5,
        ///     "salary": 600,
        ///     "isActive": true,
        ///     "createionDate": "2024-02-03T06:49:52.758Z"
        ///  }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCoachEmployeeAction(UpdateCoachEmployeeDTO dto)
        {
            try
            {
                await UpdateCoachEmployee(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Employee and Coach Update successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Update Employee and Coach Failed  {ex.Message}" };
            }
        }
        /// <summary>
        /// Delete the selected Coach or Employee in GYM.
        /// </summary>
        /// <response code="201">The Coach or Employee has been deleted successfully</response>
        /// <response code="400">Somthing went wrong</response>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Coach or Employee
        ///    {
        ///        "PersonID": 8,
        ///        "isActive": false
        ///    }
        /// </remarks>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> DeleteCoachEmployeeAction(DeleteCoachEmployeeDTO dto)
        {
            try
            {
                await DeleteCoachEmployee(dto);
                return new ObjectResult(null) { StatusCode = 201, Value = "Employee and Coach Delete successful" };
            }
            catch (Exception ex)
            {

                return new ObjectResult(null) { StatusCode = 500, Value = $"Delete Employee and Coach Failed  {ex.Message}" };
            }
        }
        #endregion
        #region Implementation
        //Subscription
        [NonAction]
        public async Task CreateNewSubscription(CreateSubscriptionDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Description))
                throw new Exception("Description is Required");
            if (string.IsNullOrEmpty(dto.Type))
                throw new Exception("MembershipType is Required");
            if (dto.Price == null)
                throw new Exception("Price is Required");
            if (dto.DurationInDays == null)
                throw new Exception("DurationInDays is Required");
            if (dto.TrainingHoursInDay == null)
                throw new Exception("TrainingHoursInDay is Required");
            if (dto.MaxNumberOfVisits == null)
                throw new Exception("MaxNumberOfVisits is Required");
            Subscription subscription = new Subscription();
            MembershipType member = (MembershipType)Enum.Parse(typeof(MembershipType), dto.Type);
            int intgender = (int)member;
            subscription.Type = (MembershipType)Enum.ToObject(typeof(MembershipType), intgender);
            subscription.Description = dto.Description;
            subscription.Price = dto.Price;
            subscription.DurationInDays = dto.DurationInDays;
            subscription.TrainingHoursInDay = dto.TrainingHoursInDay;
            subscription.MaxNumberOfVisits = dto.MaxNumberOfVisits;
            await _context.AddAsync(subscription);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task UpdateSubscription(UpdateSubscriptionDTO dto)
        {
            var subscription = await _context.Subscriptions.FindAsync(dto.SubscriptionID);
            MembershipType member = (MembershipType)Enum.Parse(typeof(MembershipType), dto.Type);
            int intgender = (int)member;
            subscription.Type = (MembershipType)Enum.ToObject(typeof(MembershipType), intgender);
            subscription.Description = dto.Description;
            subscription.Price = dto.Price;
            subscription.DurationInDays = dto.DurationInDays;
            subscription.TrainingHoursInDay = dto.TrainingHoursInDay;
            subscription.MaxNumberOfVisits = dto.MaxNumberOfVisits;
            subscription.IsActive = dto.IsActive;
            subscription.CreateionDate = dto.CreateionDate;
            _context.Update(subscription);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task DeleteSubscription(DeleteSubscriptionDTO dto)
        {
            var subscription = await _context.Subscriptions.FindAsync(dto.SubscriptionID);
            subscription.SubscriptionID = dto.SubscriptionID;
            subscription.IsActive = dto.IsActive;
            _context.Update(subscription);
            await _context.SaveChangesAsync();
        }
        //Department
        [NonAction]
        public async Task CreateNewDepartment(CreateDepartmentDTO dto)
        {
            if (string.IsNullOrEmpty(dto.NameInEnglish))
                throw new Exception("NameInEnglish is Required");
            if (string.IsNullOrEmpty(dto.NameInArabic))
                throw new Exception("NameInArabic is Required");
            if (string.IsNullOrEmpty(dto.Description))
                throw new Exception("Description is Required");
            Department department = new Department();
            department.NameInArabic = dto.NameInArabic;
            department.NameInEnglish = dto.NameInEnglish;
            department.Description = dto.Description;
            await _context.AddAsync(department);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task UpdateDepartment(UpdateDepartmentDTO dto)
        {

            var department = await _context.Departments.FindAsync(dto.DepartmentID);
            department.NameInArabic = dto.NameInArabic;
            department.NameInEnglish = dto.NameInEnglish;
            department.Description = dto.Description;
            department.IsActive = dto.IsActive;
            department.CreateionDate = dto.CreateionDate;
            _context.Update(department);
            await _context.SaveChangesAsync();
        }    
        [NonAction]
        public async Task DeleteDepartment(DeleteDepartmentDTO dto)
        {
            var department = await _context.Departments.FindAsync(dto.DepartmentID);
            department.DepartmentID = dto.DepartmentID;
            department.IsActive = dto.IsActive;
            _context.Update(department);
            await _context.SaveChangesAsync();
        }
        //Admin
        [NonAction]
        public async Task CreateNewAdmin(CreateCoachEmployeeDTO dto)
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
            Person Admin = new Person();
            Admin.FullName = dto.FullName;
            Admin.PhoneNumber = dto.PhoneNumber;
            Admin.Email = dto.Email;
            Admin.NationalID = dto.NationalID;
            Admin.PassWord = dto.PassWord;
            Admin.BirthDate = dto.BirthDate;
            Admin.Age = dto.Age;
            Admin.Salary = dto.Salary;
            Admin.Department = await _context.Departments.FindAsync(2);
            Admin.personType = (PersonType)Enum.ToObject(typeof(PersonType), 1);
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), dto.genderType);
            int intgender = (int)gender;
            Admin.genderType = (GenderType)Enum.ToObject(typeof(GenderType), intgender);
            await _context.AddAsync(Admin);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task UpdateAdminِAccount(UpdateAdminDTO dto)
        {
            var Admin = await _context.People.FindAsync(dto.PersonID);
            Admin.FullName = dto.FullName;
            Admin.PassWord = dto.PassWord;
        
            _context.Update(Admin);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task LoginAdmin(LoginDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.PassWord))
                throw new Exception("Email or Phone Number or Password are Required");
            var login = await _context.People
                .Where(x => x.Email.Equals(dto.Email) || x.PhoneNumber.Equals(dto.PhoneNumber) && x.PassWord.Equals(dto.PassWord))
                .SingleOrDefaultAsync();
            if (login == null)
            {
                throw new Exception("Email, Phone Number or Password are not correct");
            }
        }
        [NonAction]
        public async Task CreateCoachEmployee(CreateCoachEmployeeDTO dto)
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
            Person Coach = new Person();
            Coach.FullName = dto.FullName;
            Coach.PhoneNumber = dto.PhoneNumber;
            Coach.Email = dto.Email;
            Coach.NationalID = dto.NationalID;
            Coach.PassWord = dto.PassWord;
            Coach.BirthDate = dto.BirthDate;
            Coach.Age = dto.Age;
            Coach.Salary = dto.Salary;
            //GenderType convert
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), dto.genderType);
            int intgender = (int)gender;
            Coach.genderType = (GenderType)Enum.ToObject(typeof(GenderType), intgender);
            //PersonType convert
            PersonType persontype = (PersonType)Enum.Parse(typeof(PersonType), dto.personType);
            int intgender1 = (int)persontype;
            Coach.personType = (PersonType)Enum.ToObject(typeof(PersonType), intgender1);
            Coach.Department = await _context.Departments.FindAsync(dto.DepartmentID);
            await _context.AddAsync(Coach);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task UpdateCoachEmployee(UpdateCoachEmployeeDTO dto)
        {
            var coach = await _context.People.FindAsync(dto.PersonID);
            coach.FullName = dto.FullName;
            coach.Email = dto.Email;
            coach.PhoneNumber = dto.PhoneNumber;
            coach.NationalID = dto.NationalID;
            coach.BirthDate = dto.BirthDate;
            coach.PassWord = dto.PassWord;
            //GenderType convert
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), dto.genderType);
            int intgender = (int)gender;
            coach.genderType = (GenderType)Enum.ToObject(typeof(GenderType), intgender);
            //PersonType convert
            PersonType persontype = (PersonType)Enum.Parse(typeof(PersonType), dto.personType);
            int intgender1 = (int)persontype;
            coach.personType = (PersonType)Enum.ToObject(typeof(PersonType), intgender1);

            coach.Department = await _context.Departments.FindAsync(dto.DepartmentID);
            coach.Specialization = dto.Specialization;
            coach.Certifications = dto.Certifications;
            coach.Salary = dto.Salary;
            coach.IsActive = dto.IsActive;
            coach.CreateionDate = dto.CreateionDate;
            _context.Update(coach);
            await _context.SaveChangesAsync();
        }
        [NonAction]
        public async Task DeleteCoachEmployee(DeleteCoachEmployeeDTO dto)
        {
            var coach = await _context.People.FindAsync(dto.PersonID);
            coach.PersonID = dto.PersonID;
            coach.IsActive = dto.IsActive;
            _context.Update(coach);
            await _context.SaveChangesAsync();
        }
        #endregion

    }
}
