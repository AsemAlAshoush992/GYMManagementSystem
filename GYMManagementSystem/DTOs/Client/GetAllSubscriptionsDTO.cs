using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Client
{
    public class GetAllSubscriptionsDTO
    {
        public string Description { get; set; }
        public MembershipType Type { get; set; }
        public float Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursInDay { get; set; }
        public int MaxNumberOfVisits { get; set; }
    }
}
