using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.Models.Entities
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string HealthStatus { get; set; }
        public string Image { get; set; }
        public GenderType genderType { get; set; }
        public string Specialization { get; set; }
        public string Certifications { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<CoachTrainingCourse> Course { get; set; }
        public virtual Subscription Subscription { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateionDate { get; set; }
        public float Salary { get; set; }
        public class Client : Person
        { 
        
        }
        public class Employee : Person
        {

        }
        public class Admin : Person
        {

        }
        public class Coach : Person
        {

        }
    }
 }
