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

        public WorkflowContext(DbContextOptions<WorkflowContext> options)
            : base(options) { }
    }
}
