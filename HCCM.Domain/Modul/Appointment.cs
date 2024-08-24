using HCCM.Domain.Enum;

namespace HCCM.Domain.Modul;

public class Appointment
{
    public int Id { get; set; }

    public States Status { get; set; }

    public DateTime Date { get; set; }

    //Forign Key:
    public int PatientId { get; set; }
  
    public int ClinicianId { get; set; }

    //Navigation Properties:
    public Patient Patient { get; set; }
    
    public Clinician Clinician { get; set; }
}
