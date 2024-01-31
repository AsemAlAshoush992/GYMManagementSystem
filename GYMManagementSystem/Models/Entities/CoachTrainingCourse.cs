namespace GYMManagementSystem.Models.Entities
{
    public class CoachTrainingCourse
    {
        public int CoachTrainingCourseID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
        public virtual TrainingCourse TrainingCourse { get; set; }
        public virtual Person Coach { get; set; }
    }
}
