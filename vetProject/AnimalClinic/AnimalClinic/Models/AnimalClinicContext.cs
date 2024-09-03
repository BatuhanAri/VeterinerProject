using Microsoft.EntityFrameworkCore;

public class AnimalClinicContext : DbContext
{
    // Constructor
    public AnimalClinicContext(DbContextOptions<AnimalClinicContext> options)
        : base(options)
    {
    }

    // DbSet Properties
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Treatment> Treatments { get; set; }
    public DbSet<Staff> Staff { get; set; }
}
