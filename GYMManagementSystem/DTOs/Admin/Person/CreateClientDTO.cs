using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Person
{
    public class CreateClientDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalID { get; set; }
        public string PassWord { get; set; }
        public DateTime BirthDate { get; set; }
        public string genderType { get; set; }
        //public string personType { get; set; }
        public int Age { get; set; }
        public IFormFile Image { get; set; }
        public byte Height { get; set; }
        public byte Weight { get; set; }
        public string HealthStatus { get; set; }
    }
}
