using Screen_design_2.Models;

public record ExecutionState
{
    public List<Executionlist> ExecutionLists { get; init; } = new();
    
    public bool IsDataLoading { get; init; } = false;
}