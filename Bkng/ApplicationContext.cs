using System;
using Bkng.Models;
using Microsoft.EntityFrameworkCore;

namespace Bkng;

public class ApplicationContext: DbContext
{
    public DbSet<Administrator> Administrators { get; set; } = null!;
    public DbSet<Booking> Bookings { get; set; } = null!;
    public DbSet<Guest> Guests { get; set; } = null!;
    public DbSet<Hotel> Hotels { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<RoomType> RoomTypes { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server=10.10.1.24;user=user_01;password=user01pro;database=pro1_23;";
        optionsBuilder.UseMySql(connectionString,
            new MySqlServerVersion(ServerVersion.AutoDetect(connectionString)));
    }
}