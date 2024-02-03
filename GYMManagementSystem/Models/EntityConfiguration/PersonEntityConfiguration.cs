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
            //Not Null and Null
            builder.Property(x => x.Height).IsRequired(false);
            builder.Property(x => x.Weight).IsRequired(false);
            builder.Property(x => x.HealthStatus).IsRequired(false);
            builder.Property(x => x.Image).IsRequired(false);
            builder.Property(x => x.Specialization).IsRequired(false);
            builder.Property(x => x.Certifications).IsRequired(false);
            builder.Property(x => x.StartDate).IsRequired(false);
            builder.Property(x => x.EndDate).IsRequired(false);
            builder.Property(x => x.Salary).IsRequired(false);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.HealthStatus).HasDefaultValue("Uninfected");
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
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_StartDate", "EndDate > StartDate AND StartDate > sysdate() AND EndDate > sysdate()"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_FullName", "LENGTH(FullName) >= 3"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_PassWord", "LENGTH(PassWord) >= 8"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_PhoneNumber", "PhoneNumber LIKE '009627________'"));
            builder.ToTable(t => t.HasCheckConstraint("CH_Person_Email", " Email LIKE '%@%.com'"));
            //Computed Column
            //builder.Property(x => x.Age).HasComputedColumnSql("TIMESTAMPDIFF(YEAR, BirthDate, sysdate())");
        }
    }
}
