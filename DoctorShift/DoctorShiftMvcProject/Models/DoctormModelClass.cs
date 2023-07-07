using static DoctorShiftMvcProject.Models.DoctormModelClass;

namespace DoctorShiftMvcProject.Models
{
    public class DoctormModelClass
    {
        // This class defining the doctor profiles. 
        public string? name { get; set; }
        public string? surname { get; set; }
        public Guid? id { get; set; }
        public enum Rank
        {
            None,
            ExaminationDoctor,
            ResuscitationDoctor,
            SurgialOperationDoctor,
            SeniorDoctor,
        }
        public int shiftNumber { get; set; }
        public int phoneNumber { get; set; }
        public bool workingState { get; set; }
        public Rank doctorRank { get; set; }

        //Constructor metod :)
        public DoctormModelClass(string Name, string Surname, Guid Id, Rank DoctorRank, int ShiftNumber, int PhoneNumber, bool WorkingState)
        {
            name = Name;
            surname = Surname;
            id = Id;
            shiftNumber = ShiftNumber;
            phoneNumber = PhoneNumber;
            workingState = WorkingState;
            doctorRank = DoctorRank;

        }
    }
}
