using Screen_design_2.Models;

public record EquipmentState
{
    public List<Equipment> EquipmentList { get; init; } = new();
    
    public bool IsDataLoading { get; init; } = false;
}