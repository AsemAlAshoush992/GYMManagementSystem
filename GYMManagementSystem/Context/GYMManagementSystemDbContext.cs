using GYMManagementSystem.Models.Entities;
using GYMManagementSystem.Models.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace GYMManagementSystem.Context
{
    public class GYMManagementSystemDbContext : DbContext
    {
        public GYMManagementSystemDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CoachTrainingCourseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SubscriptionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingCourseEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingCourseSubscriptionEntityConfiguration());
        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<TrainingCourse> TrainingCourses { get; set; }
        public virtual DbSet<TrainingCourseSubscription> TrainingCourseSubscriptions { get; set; }
        public virtual DbSet<CoachTrainingCourse> CoachTrainingCourses { get; set; }
    }
}
