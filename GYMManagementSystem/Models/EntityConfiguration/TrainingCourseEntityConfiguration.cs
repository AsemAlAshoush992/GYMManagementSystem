using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class TrainingCourseEntityConfiguration : IEntityTypeConfiguration<TrainingCourse>
    {
        public void Configure(EntityTypeBuilder<TrainingCourse> builder)
        {
            builder.ToTable("TrainingCourse");
            builder.HasKey(X => X.TrainingCourseID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
            //Not Null Constraint
            builder.Property(x => x.Name).IsRequired();
            //Size 
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Name).HasMaxLength(20);
            //Nvarchar
            builder.Property(x => x.Name).IsUnicode();
            builder.Property(x => x.Description).IsUnicode();

        }
    }
}
