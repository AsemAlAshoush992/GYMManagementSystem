﻿using static GYMManagementSystem.Helper.Enums.Enums;

namespace GYMManagementSystem.DTOs.Admin.Subscription
{
    public class CreateSubscriptionDTO
    {
        
        public string Description { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public int DurationInDays { get; set; }
        public int TrainingHoursInDay { get; set; }
        public int MaxNumberOfVisits { get; set; }
    }
}
