using Fluxor;
using Screen_design_2.Models;
public class WorkTypeFeature : Feature<WorkTypeState>
{
    public override string GetName() => "WorkType";

    protected override WorkTypeState GetInitialState() =>
    new WorkTypeState
    {
        WorkTypes = new List<WorkType>
        {
            new WorkType{ Work_Type = "Put away", Description = "Put away tasks", Task_priority = "30"},
                new WorkType{ Work_Type = "Picking", Description = "Picking tasks", Task_priority = "20"},
                new WorkType{ Work_Type = "Cycle Count", Description = "CC tasks", Task_priority = "10"},
        },
    };
}