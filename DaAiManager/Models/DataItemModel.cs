using System;

namespace DaAiManager.Models;

public class DataItemModel
{
    public int Id { get; set; }
    public string? Customer { get; set; }
    public string? Caregivers { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan ManHour { get; set; }
    public decimal Amount { get; set; }
}