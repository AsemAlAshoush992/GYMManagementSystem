﻿using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Person
{
    public class UpdateCoachEmployeeDTO
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalID { get; set; }
        public string PassWord { get; set; }
        public DateTime BirthDate { get; set; }
        public string Image { get; set; }
        public string genderType { get; set; }
        public string personType { get; set; }
        public string Specialization { get; set; }
        public string Certifications { get; set; }
        public int DepartmentID { get; set; }
        public float Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
    }
}
