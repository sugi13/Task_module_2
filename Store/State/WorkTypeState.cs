using Screen_design_2.Models;

public record WorkTypeState
{
    public List<WorkType> WorkTypes { get; init; } = new();
    public bool IsLoading { get; init; } = false;
}