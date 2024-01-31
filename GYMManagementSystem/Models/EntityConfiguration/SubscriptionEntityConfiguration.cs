using GYMManagementSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GYMManagementSystem.Models.EntityConfiguration
{
    public class SubscriptionEntityConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscription");
            builder.HasKey(X => X.SubscriptionID);
            //Default Constraint
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreateionDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Price).HasDefaultValue(15);
            //Size 
            builder.Property(x => x.Description).HasMaxLength(25);
            //Nvarchar
            builder.Property(x => x.Description).IsUnicode();
            //Check Constraint
            builder.ToTable(t => t.HasCheckConstraint("CH_Subscription_StartDate", "EndDate > StartDate AND StartDate > sysdate() AND EndDate > sysdate()"));
            //Computed Column
            //builder.Property(x => x.DurationInDays).HasComputedColumnSql("DATEDIFF(DAY, [StartDate], [EndDate])");
        }
    }
}
