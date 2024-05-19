using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fit_IT_API.Models;

namespace Fit_IT_API.Data
{
    public class Fit_IT_APIContext : DbContext
    {
        public Fit_IT_APIContext (DbContextOptions<Fit_IT_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Fit_IT_API.Models.Goal> Goal { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Recommendation> Recommendation { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Progress> Progress { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.User> User { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Vital> Vital { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Profile> Profile { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Workout> Workout { get; set; } = default!;
        public DbSet<Fit_IT_API.Models.Reminder> Reminder { get; set; } = default!;
    }
}
