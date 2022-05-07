using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Context
{
    public class DataContext : DbContext
    {
        public DbSet<MyTask> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // tasks
            modelBuilder.Entity<MyTask>().Property(t => t.Description).HasMaxLength(500);
            modelBuilder.Entity<MyTask>().Property(t => t.TaskStatus).HasConversion<string>();
            modelBuilder.Entity<MyTask>().Property(t => t.TaskStatus).HasDefaultValue(Core.Enums.TaskStatus.ToDo);

            // projects
            modelBuilder.Entity<Project>().Property(t => t.ProjectStatus).HasConversion<string>();
            
        }
    }
}