using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class TrainingCourseSubscriptionEntityConfiguration : IEntityTypeConfiguration<TrainingCourseSubscription>
    {
        public void Configure(EntityTypeBuilder<TrainingCourseSubscription> builder)
        {
            builder.ToTable("TrainingCourseSubscription");
            builder.HasKey(X => X.TrainingCourseSubscriptionID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
        }
    }
}
