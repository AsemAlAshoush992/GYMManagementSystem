namespace GYMManagementSystem.Models.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string NameInArabic { get; set; }
        public string NameInEnglish { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
        public virtual List<Person> People { get; set; }
        public virtual List<TrainingCourse> Courses { get; set; } 

    }
}
