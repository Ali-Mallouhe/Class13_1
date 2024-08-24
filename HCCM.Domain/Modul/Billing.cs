using HCCM.Domain.Enum;

namespace HCCM.Domain.Modul;

public class Billing
{
    //Bill Properties:
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public States Status { get; set; }

    public Methods Method { get; set; }

    //Forign Key
    public int PatientId { get; set; }


    //Navigation Properties:
    public Patient Patient { get; set; }

}