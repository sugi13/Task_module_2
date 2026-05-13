using Fluxor;
using Screen_design_2.Models;

public class EquipmentFeature: Feature<EquipmentState>
{
    public override string GetName() => "Equipment Eligibility";

    protected override EquipmentState GetInitialState() => 
    new EquipmentState
    {
         EquipmentList = new List<Equipment>
         {
           new Equipment { equipment_eligibility = "Pallet Jacks" },
           new Equipment { equipment_eligibility = "Fork Lift" },
         }
    };
    
}