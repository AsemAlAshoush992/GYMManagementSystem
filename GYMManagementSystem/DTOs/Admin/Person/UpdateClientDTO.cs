using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Person
{
    public class UpdateClientDTO
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalID { get; set; }
        public string PassWord { get; set; }
        public DateTime BirthDate { get; set; }
        public GenderType genderType { get; set; }
        public PersonType personType { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HealthStatus { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
    }
}
