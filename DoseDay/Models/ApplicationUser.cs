using Microsoft.AspNetCore.Identity;

namespace DoseDay.Models;

public class ApplicationUser : IdentityUser<int>
{
    public string TimeZoneId { get; set; } = "America/Mexico_City";

    public ICollection<TrackedItem> TrackedItems { get; set; } = [];
}