using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class PersonEntityConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(X => X.PersonID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.HealthStatus).HasDefaultValue("Uninfected");
            builder.Property(x => x.Salary).HasDefaultValue(260);
            //Size 
            builder.Property(x => x.FullName).HasMaxLength(14);
            builder.Property(x => x.PassWord).HasMaxLength(15);
            builder.Property(x => x.NationalID).HasMaxLength(10);
            builder.Property(x => x.HealthStatus).HasMaxLength(20);
            builder.Property(x => x.Specialization).HasMaxLength(20);
            builder.Property(x => x.Certifications).HasMaxLength(20);
            //Nvarchar
            builder.Property(x => x.FullName).IsUnicode();
            builder.Property(x => x.PassWord).IsUnicode();
            //Unique Constraint
            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.PhoneNumber).IsUnique();
            builder.HasIndex(x => x.NationalID).IsUnique();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_FullName", "LENGTH(FullName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_PassWord", "PassWord LIKE '[1-9]'"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_PhoneNumber", "PhoneNumber LIKE '009627________'"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_Email", " Email LIKE '%@%.com'"));
            //Computed Column
            //builder.Property(x => x.Age).HasComputedColumnSql("TIMESTAMPDIFF(YEAR, BirthDate, sysdate())");
        }
    }
}
