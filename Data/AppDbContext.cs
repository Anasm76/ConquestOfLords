using Microsoft.EntityFrameworkCore;

namespace ConquestOfLords.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<TeamAssignment> TeamAssignments => Set<TeamAssignment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasIndex(e => e.InGameName).IsUnique();
            entity.HasIndex(e => e.AccessCode).IsUnique();

            entity.Property(e => e.InGameName).HasMaxLength(50);
            entity.Property(e => e.AccessCode).HasMaxLength(6);
        });

        modelBuilder.Entity<TeamAssignment>(entity =>
        {
            entity.Property(e => e.AssignmentText).HasColumnType("ntext");
        });
    }
}