namespace HCCM.Domain.Modul;

public class Address
{
    public int Id { get; set; }

    public string Country { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string StreetNumber { get; set; } = string.Empty;

    public string BuildingName { get; set; } = string.Empty;

    // Navigation Properties
    public Patient Patient { get; set; }
    public Clinician Clinician { get; set; }
}
