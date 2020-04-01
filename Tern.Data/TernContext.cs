using Microsoft.EntityFrameworkCore;
using Tern.Domain;

namespace Tern.Data
{
    public class TernContext : DbContext
    {
        public TernContext(DbContextOptions<TernContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Status> Status { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasOne(x => x.List)
                .WithMany(y => y.Tasks)
                .HasForeignKey(z => z.ListId)
                .HasConstraintName("FK_List_ListId")
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Task>()
                .HasOne(x => x.Status)
                .WithMany(y => y.Tasks)
                .HasForeignKey(z => z.StatusId)
                .HasConstraintName("FK_Status_Task_StatusId")
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<SubTask>()
                .HasOne(x => x.Task)
                .WithMany(y => y.SubTasks)
                .HasForeignKey(z => z.TaskId)
                .HasConstraintName("FK_Task_TaskId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubTask>()
                .HasOne(x => x.Status)
                .WithMany(y => y.SubTasks)
                .HasForeignKey(z => z.StatusId)
                .HasConstraintName("FK_Status_SubTask_StatusId")
                .OnDelete(DeleteBehavior.ClientNoAction);
        }
    }
}
