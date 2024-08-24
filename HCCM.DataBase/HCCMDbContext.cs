using HCCM.Domain.Modul;
using Microsoft.EntityFrameworkCore;

namespace HCCM.DataBase;

public class HCCMDbContext : DbContext
{
    public DbSet<Clinician> Clinicians { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Billing> Billings { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; " +
                                    "Initial Catalog = HCCM_Data");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

       
        //One To One Relation Between Patient and Address:
        modelBuilder.Entity<Patient>()
            .HasOne(p => p.Address)
            .WithOne(a => a.Patient)
            .HasForeignKey<Patient>(p => p.AddressId);

        //One To One Relation Between Clinician and Address:
        modelBuilder.Entity<Clinician>()
            .HasOne(c => c.Address)
            .WithOne(a => a.Clinician)
            .HasForeignKey<Clinician>(c => c.AddressId);
    }
}
