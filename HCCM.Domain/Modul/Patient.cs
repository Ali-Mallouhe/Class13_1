namespace HCCM.Domain.Modul
{
    public class Patient
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public DateTime DOB { get; set; }

        public string Gender { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
        // Foreign key to Address
        public int AddressId { get; set; }  
        
        // Navigation properties
        public List<Billing> Bills { get; set; } = new List<Billing>();

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public List<Clinician> Clinicians { get; set; } = new List<Clinician>();

        public Address Address { get; set; }
    }
}
