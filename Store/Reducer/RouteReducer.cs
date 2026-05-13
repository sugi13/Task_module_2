using Fluxor;
public static class RouteReducers
{
    [ReducerMethod]
    public static RouteState createRoute(RouteState state, CreateRouteAction action)
    {
        var updatedRouteLists =  state.RouteLists.ToList(); ;
        updatedRouteLists.Add(action.NewRoute);
        return state with { RouteLists = updatedRouteLists };
    }

    [ReducerMethod]
    public static RouteState updateRoute(RouteState state, UpdateRouteAction action)
    {
        var updatedRouteLists = state.RouteLists.Select(el =>
         el.Starting == action.UpdatedRoute.Starting ? action.UpdatedRoute : el
     ).ToList();
        return state with
        {
            RouteLists = updatedRouteLists,
        };
    }
}