using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.Models.Entities
{
    public class TrainingCourse
    {
        public int TrainingCourseID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public IntensityLevel intensityLevel { get; set; }
        public string Schedule { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<CoachTrainingCourse> Coach { get; set; }
        public virtual List<TrainingCourseSubscription> TrainingCourseSubscription { get; set; }


    }
}
