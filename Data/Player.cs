namespace ConquestOfLords.Data;
public class Player
{
    public int Id { get; set; }
    public string InGameName { get; set; } = "";
    public string Alliance { get; set; } = ""; 
    public TroopType TroopType { get; set; }
    public int TroopLevel { get; set; }
    public int TroopCapacity { get; set; }
    public int RallySize { get; set; }
    public int MaxDenLevel { get; set; }
    public int PreferredShift { get; set; }  // 1 = First, 2 = Second, 3 = Both, 4 = Any
    public bool IsAvailableExtendedHours { get; set; }
    public bool IsWillingToCaptain { get; set; }
    public string AccessCode { get; set; } = "";
    public bool IsParticipating { get; set; } = true;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
