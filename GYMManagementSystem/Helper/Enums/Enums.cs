namespace GYMManagementSystem.Helper.Enums
{
    public class Enums
    {
        public enum GenderType
        {
            Male,
            Female
        }
        public enum MembershipType
        {
            Basic,
            Premium,
            Gold,
            Family,
            VIP
        }
        public enum PaymentMethod
        {
            Cash,
            CreditCard,
            ZainCash,
            OrangeMony
        }
        public enum IntensityLevel
        {
            Beginner,
            Intermediate,
            Advanced
        }
        public enum PersonType
        {
            Employee,
            Admin,
            client,
            Coach
        }

        public enum SubscriptionStatus
        {
            Activate,
            Reactivate,
            Disactivate,
            Expired,
        }
        public enum CourseTrainingName
        {
            Cardio,
            Weightlifting,
            Yoga,
            Pilates,
            CrossFit,
            Kickboxing,
            KoreanTaekwondo
        }
        
    }
}
