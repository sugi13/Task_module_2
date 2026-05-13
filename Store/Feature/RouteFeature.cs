using Fluxor;
using Screen_design_2.Models;

public class RouteFeature: Feature<RouteState>
{
    public override string GetName() => "Route Eligibility";

    protected override RouteState GetInitialState() => 
    new RouteState
    {
            RouteLists = new List<Routelist>
            {
             new Routelist {equipment = "Pallet Jacks", Starting = "RCV WG/WA", Destination = "DRY WG/WA 1", Next = "No Drop"},
             new Routelist {equipment = "Pallet Jacks", Starting = "RCV WG/WA", Destination = "DRY WG/WA 2", Next = "No Drop"},
                new Routelist {equipment = "Fork Lift", Starting = "RCV WG/WA", Destination = "BAR WG/WA1", Next = "DRP WG/WA1"},
                    new Routelist {equipment = "Fork Lift", Starting = "RCV WG/WA", Destination = "DRY WG/WA1", Next = "No Drop"},
            }
    };
    
}