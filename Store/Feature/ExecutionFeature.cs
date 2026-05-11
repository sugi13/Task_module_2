using Fluxor;
using Screen_design_2.Models;


public class ExecutionFeature: Feature<ExecutionState>
{
    public override string GetName() => "Execution";

    protected override ExecutionState GetInitialState() => 
    new ExecutionState
    {
       ExecutionLists = new List<Executionlist>
       {
        new Executionlist {Container_status = "Recieved", Work_action_process = "Locate Container"},
        new Executionlist {Container_status = "Located", Work_action_process = "Locate Container"},
        new Executionlist {Container_status = "In Shipment", Work_action_process = "Locate Container"}      
              
       }
    };
}