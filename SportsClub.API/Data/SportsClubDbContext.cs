﻿using Microsoft.EntityFrameworkCore;
using SportsClub.API.Entities;

namespace SportsClub.API.Data
{
    public class SportsClubDbContext(DbContextOptions<SportsClubDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base call is only needed when inheriting from IdentityDbContext, default implementation does nothing
            base.OnModelCreating(modelBuilder);

            // For EF Data seeding, see: https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding
            modelBuilder.Entity<Location>().HasData(SportClubSeedData.Locations);
            modelBuilder.Entity<Workout>().HasData(SportClubSeedData.Workouts);
            modelBuilder.Entity<Lesson>().HasData(SportClubSeedData.Lessons);
            modelBuilder.Entity<Enrollment>();
        }

        public DbSet<Location> Locations => Set<Location>();
        public DbSet<Workout> Workouts => Set<Workout>();
        public DbSet<Lesson> Lessons => Set<Lesson>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
    }
}
