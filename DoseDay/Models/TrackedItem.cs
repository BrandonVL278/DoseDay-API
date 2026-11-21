namespace DoseDay.Models;

public class TrackedItem
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; } = null!;

    public required string Name { get; set; }

    // Cantidad que tiene el usuario al comenzar a llevar el control.
    public decimal StartingQuantity { get; set; }

    // Ejemplos: "servicios", "cápsulas", "g", "ml".
    public required string Unit { get; set; }

    // Color hexadecimal, por ejemplo "#3B82F6".
    public string ColorHex { get; set; } = "#3B82F6";

    public int AlertThresholdPercent { get; set; } = 20;
    public bool IsActive { get; set; } = true;

    public ICollection<UsageSchedule> UsageSchedules { get; set; } = [];
    // Dentro de TrackedItem
    public ICollection<InventoryMovement> InventoryMovements { get; set; } = [];
}