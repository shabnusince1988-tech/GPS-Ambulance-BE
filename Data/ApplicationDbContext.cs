using AmbulanceAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using AmbulanceAPI.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Hospital> Hospitals { get; set; }
    public DbSet<Ambulance> Ambulances { get; set; }
    public DbSet<TrafficSignal> TrafficSignals { get; set; }
    public DbSet<Mission> Missions { get; set; }
    public DbSet<VitalsLog> VitalsLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ensure decimal precision for Latitude/Longitude
        modelBuilder.Entity<Hospital>().Property(h => h.Latitude).HasPrecision(18, 15);
        modelBuilder.Entity<Hospital>().Property(h => h.Longitude).HasPrecision(18, 15);
    }
}
