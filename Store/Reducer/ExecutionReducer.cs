using Fluxor;

public static class ExecutionListReducers
{
    [ReducerMethod]
    public static ExecutionState createExecution(ExecutionState state, CreateExecutionAction action)
    {
        {
            var updatedExecutionLists = state.ExecutionLists.ToList(); ;
            updatedExecutionLists.Add(action.NewExecution);
            return state with { ExecutionLists = updatedExecutionLists };
        }

    }
    public static ExecutionState updateExecution(ExecutionState state, UpdateExecutionAction action)
    {
        var updatedExecutionLists = state.ExecutionLists.Select(el =>
         el.Container_status == action.UpdatedExecution.Container_status ? action.UpdatedExecution : el
     ).ToList();
        return state with
        {
            ExecutionLists = updatedExecutionLists,
        };
    }
}