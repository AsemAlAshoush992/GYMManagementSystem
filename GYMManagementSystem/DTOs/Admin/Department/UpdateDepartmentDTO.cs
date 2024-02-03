namespace GYMManagementSystem.DTOs.Admin.Department
{
    public class UpdateDepartmentDTO
    {
        public int DepartmentID { get; set; }
        public string NameInArabic { get; set; }
        public string NameInEnglish { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
    }
}
