using System;
using Microsoft.EntityFrameworkCore;

namespace PestControl.Data {
    public class BugDbContext : DbContext {
		public BugDbContext(DbContextOptions<BugDbContext> options): base(options) { }


		protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Defines 1..* relationship with Comment
			modelBuilder.Entity<Models.Bug>().HasMany(e => e.Comments).WithOne(e => e.Bug).HasForeignKey(e => e.BugId);

            // Creates singular table name (Bug not Bugs)
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }

		public DbSet<Models.Bug> Bugs { get; set; }
	}   
}
