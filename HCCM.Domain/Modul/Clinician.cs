using HCCM.Domain.Enum;

namespace HCCM.Domain.Modul
{
    public class Clinician
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public DateTime DOB { get; set; }

        public string Gender { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public Specializations Specialization { get; set; }

        public string WorkingShift { get; set; } = string.Empty;

        // Foreign key to Address
        public int AddressId { get; set; }  
        
        //Navigation Properties:
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Address Address { get; set; }
    }
}
