using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class WorkflowContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Resolve> Resolves { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<History> Histories { get; set; }

        public WorkflowContext(DbContextOptions<WorkflowContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>(act =>
            {
                act.HasOne(field => field.UserOut)
                .WithMany(fk => fk.HistoriesOut)
                .HasForeignKey(fk => fk.HUser);

                act.HasOne(field => field.User)
                .WithMany(fk => fk.Histories)
                .HasForeignKey(fk => fk.UId);
            });
        }
    }
}
