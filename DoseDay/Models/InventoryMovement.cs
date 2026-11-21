namespace DoseDay.Models;

public enum InventoryMovementType
{
    Restock,
    Adjustment
}

public class InventoryMovement
{
    public int Id { get; set; }

    public int TrackedItemId { get; set; }
    public TrackedItem TrackedItem { get; set; } = null!;

    public InventoryMovementType Type { get; set; }

    // Positivo para una reposición o aumento; negativo para una reducción.
    public decimal QuantityChange { get; set; }

    public string? Note { get; set; }

    public DateTimeOffset OccurredAt { get; set; } =
        DateTimeOffset.UtcNow;
}