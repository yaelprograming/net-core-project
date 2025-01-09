using Microsoft.EntityFrameworkCore;
using ParkingManager.Core.Entites;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace ParkingManager.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<ParkingLot> ParkingLots { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //public DataContext()
        //{
        //string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
        //string jsonString = File.ReadAllText(path);
        //DataStructure? data = System.Text.Json.JsonSerializer.Deserialize<DataStructure>(jsonString);
        //Customers = data.Customers;
        //ParkingSpots = data.ParkingSpots;
        //ParkingLots = data.ParkingLots;
        //Payments = data.Payments;
        //Reservations = data.Reservations;

    }
    //    public void SaveChange()
    //    {
    //        string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
    //        var data = new
    //        {
    //            Customers = this.Customers,
    //            ParkingSpots = this.ParkingSpots,
    //            ParkingLots = this.ParkingLots,
    //            Payments = this.Payments,
    //            Reservations = this.Reservations
    //        };

    //        string jsonString = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions
    //        {
    //            WriteIndented = true
    //        });
    //        File.WriteAllText(path, jsonString);
    //    }
    //}

    //public class DataStructure
    //{
    //    public List<Customer> Customers { get; set; } = new List<Customer>();
    //    public List<ParkingLot> ParkingLots { get; set; } = new List<ParkingLot>();
    //    public List<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();
    //    public List<Payment> Payments { get; set; } = new List<Payment>();
    //    public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    //}
}

