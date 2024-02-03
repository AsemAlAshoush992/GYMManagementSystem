using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Client
{
    public class GetAllCoachesDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public string genderType { get; set; }
        public string Specialization { get; set; }
        public string Certifications { get; set; }

    }
}
