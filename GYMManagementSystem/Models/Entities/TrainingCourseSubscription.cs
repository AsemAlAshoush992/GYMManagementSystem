namespace GYMManagementSystem.Models.Entities
{
    public class TrainingCourseSubscription
    {
        public int TrainingCourseSubscriptionID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual TrainingCourse TrainingCourse { get; set; }

    }
}
