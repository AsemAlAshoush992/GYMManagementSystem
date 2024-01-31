using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class CoachTrainingCourseEntityConfiguration : IEntityTypeConfiguration<CoachTrainingCourse>
    {
        public void Configure(EntityTypeBuilder<CoachTrainingCourse> builder)
        {
            builder.ToTable("CoachTrainingCourse");
            builder.HasKey(X => X.CoachTrainingCourseID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
        }
    }
}
