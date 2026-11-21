namespace DoseDay.Models;

public class UsageScheduleDay
{
    public int UsageScheduleId { get; set; }

    // Usa los valores de System.DayOfWeek:
    // Sunday, Monday, Tuesday, etc.
    public DayOfWeek Day { get; set; }

    public UsageSchedule UsageSchedule { get; set; } = null!;
}