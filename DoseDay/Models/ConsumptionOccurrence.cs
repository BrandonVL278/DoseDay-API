namespace DoseDay.Models;

public enum ConsumptionStatus
{
    Pending,
    Consumed,
    Skipped,
    Partial
}

public class ConsumptionOccurrence
{
    public int Id { get; set; }

    public int UsageScheduleId { get; set; }
    public UsageSchedule UsageSchedule { get; set; } = null!;

    // Fecha y hora local programadas para esta ocurrencia.
    public DateOnly OccurrenceDate { get; set; }
    public TimeOnly? ScheduledTime { get; set; }

    public decimal PlannedQuantity { get; set; }
    public decimal ConsumedQuantity { get; set; }

    public ConsumptionStatus Status { get; set; } =
        ConsumptionStatus.Pending;

    public DateTimeOffset CreatedAt { get; set; } =
        DateTimeOffset.UtcNow;
}