using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(X => X.DepartmentID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.NameInEnglish).HasDefaultValue("Training and Observing");
            //Not Null Constraint
            builder.Property(x => x.NameInArabic).IsRequired();
            builder.Property(x => x.NameInEnglish).IsRequired();
            builder.Property(x => x.Description).IsRequired(false);
            //Size 
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.NameInArabic).HasMaxLength(25);
            builder.Property(x => x.NameInEnglish).HasMaxLength(25);
            //Nvarchar
            builder.Property(x => x.NameInArabic).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Department_NameInArabic", "LENGTH(NameInArabic) >= 4"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Department_NameInEnglish", "LENGTH(NameInEnglish) >= 4"));
        }
    }
}
