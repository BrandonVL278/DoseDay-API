namespace DoseDay.Models;

public class UsageSchedule
{
    public int Id { get; set; }

    public int TrackedItemId { get; set; }
    public TrackedItem TrackedItem { get; set; } = null!;

    public decimal QuantityPerOccurrence { get; set; }

    public DateOnly StartsOn { get; set; }
    public DateOnly? EndsOn { get; set; }

    // Opcional: hora local en que está programado el consumo.
    public TimeOnly? LocalTime { get; set; }

    public bool IsActive { get; set; } = true;

    public ICollection<UsageScheduleDay> Days { get; set; } = [];
    // Dentro de UsageSchedule
    public ICollection<ConsumptionOccurrence> Occurrences { get; set; } = [];
}