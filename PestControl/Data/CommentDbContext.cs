using System;
using Microsoft.EntityFrameworkCore;

namespace PestControl.Data {
	public class CommentDbContext : DbContext{
		public CommentDbContext(DbContextOptions<CommentDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Models.Comment>().HasOne(e => e.Bug).WithMany(e => e.Comments).HasForeignKey(e => e.BugId).IsRequired();
            // Creates singular table name (Bug not Bugs)
            foreach (var entityType in modelBuilder.Model.GetEntityTypes()) {
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }
		public DbSet<Models.Comment> Comments { get; set; }
    }
}

