

using Fluxor;

public static class EquipmentReducers
{
    [ReducerMethod]
    public static EquipmentState createEquipment(EquipmentState state, CreateEquipmentAction action)
    {
        var updatedEquipmentLists = state.EquipmentList.ToList(); ;
        updatedEquipmentLists.Add(action.NewEquipment);
        return state with { EquipmentList = updatedEquipmentLists };
    }

    [ReducerMethod]
    public static EquipmentState updateEquipment(EquipmentState state, UpdateEquipmentAction action)
    {
        var updatedEquipmentLists = state.EquipmentList.Select(el =>
         el.equipment_eligibility == action.UpdatedEquipment.equipment_eligibility ? action.UpdatedEquipment : el
     ).ToList();
        return state with
        {
            EquipmentList = updatedEquipmentLists,
        };
    }
}