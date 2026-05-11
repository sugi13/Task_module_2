using Fluxor;
public static class WorkTypeReducers
{
  [ReducerMethod]
  public static WorkTypeState CreateWorkType(WorkTypeState state, CreateWorkTypeAction action)
  {
    var updatedWorkTypes = state.WorkTypes.ToList();
    updatedWorkTypes.Add(action.NewWorkType);
    return state with { WorkTypes = updatedWorkTypes };
  }

  [ReducerMethod]
  public static WorkTypeState UpdateWorkType(WorkTypeState state, UpdateWorkTypeAction action)
  {
    var updatedWorkTypes = state.WorkTypes.Select(wt =>
        wt.Work_Type == action.UpdatedWorkType.Work_Type ? action.UpdatedWorkType : wt
    ).ToList();
    return state with
    {
      WorkTypes = updatedWorkTypes,
    };
  }
}