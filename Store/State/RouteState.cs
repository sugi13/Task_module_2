using Screen_design_2.Models;

public record RouteState
{
    public List<Routelist> RouteLists { get; init; } = new();
    
    public bool IsDataLoading { get; init; } = false;
}