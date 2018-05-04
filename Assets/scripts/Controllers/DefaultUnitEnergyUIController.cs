using UnityEngine;

public class DefaultUnitEnergyUIController : UnitEnergyUIController
{
    private AbilityUser AbilityUser;

    private void Start()
    {
        AbilityUser = GetComponentInParent<AbilityUser>();
    }

    public override void UpdateUnitEnergyUI(UnitEnergyUI unitEnergyUI)
    {
        unitEnergyUI.EnergyBarBackground.localScale = new Vector3(AbilityUser.MaxEnergy, unitEnergyUI.EnergyBarBackground.localScale.y, unitEnergyUI.EnergyBarBackground.localScale.z);
        unitEnergyUI.EnergyBarForeground.localScale = new Vector3(AbilityUser.CurrentEnergy, unitEnergyUI.EnergyBarForeground.localScale.y, unitEnergyUI.EnergyBarForeground.localScale.z);
    }
}
