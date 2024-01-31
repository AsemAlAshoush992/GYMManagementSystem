using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Subscription
{
    public class UpdateSubscriptionDTO
    {
        public int SubscriptionID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public MembershipType Type { get; set; }

        public float Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursInDay { get; set; }
        public int MaxNumberOfVisits { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
    }
}
