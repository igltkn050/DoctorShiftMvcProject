namespace DoctorShiftMvcProject.Models
{
    public class ShiftClass
    {
        public bool nightShift { get; set; }
        public bool morningShift { get; set; }
        public bool weekend { get; set; }
        public bool weekday { get; set; }
        public enum days
        {
            Monday,
            Tuesday,
            Wensday,
            Thirsday,
            Friday,
            Saturday,
            Sunday,
        }
        public ShiftClass(bool MorningShift, bool Weekday, days Days)
        {
            morningShift = MorningShift;
            weekday = Weekday;
            if (morningShift)
            {
                nightShift = false;
            }
            else
            {
                nightShift = true;
            }
            if (weekday)
            {
                weekend = false;
            }
            else
            {
                weekend = true;
            }


        }
    }
}
