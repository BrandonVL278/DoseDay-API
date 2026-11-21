using DoseDay.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoseDay.Data
{
    public class DoseDayDbContext: IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public DoseDayDbContext(DbContextOptions<DoseDayDbContext> options): base(options)
        {
        }

        public DbSet<TrackedItem> TrackedItems => Set<TrackedItem>();
        public DbSet<UsageSchedule> UsageSchedules => Set<UsageSchedule>();
        public DbSet<UsageScheduleDay> UsageScheduleDays => Set<UsageScheduleDay>();
        public DbSet<ConsumptionOccurrence> ConsumptionOccurrences => Set<ConsumptionOccurrence>();
        public DbSet<InventoryMovement> InventoryMovements => Set<InventoryMovement>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoseDayDbContext).Assembly);
        }
    }
}
