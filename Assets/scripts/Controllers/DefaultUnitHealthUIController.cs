using UnityEngine;

public class DefaultUnitHealthUIController : UnitHealthUIController
{
    private Health Health;

    private void Start()
    {
        Health = GetComponentInParent<Health>();
    }

    public override void UpdateUnitHealthUI(UnitHealthUI unitHealthUI)
    {
        unitHealthUI.HealthBarBackground.localScale = new Vector3(Health.MaxHealth, unitHealthUI.HealthBarBackground.localScale.y, unitHealthUI.HealthBarBackground.localScale.z);
        unitHealthUI.HealthBarForeground.localScale = new Vector3(Health.CurrentHealth, unitHealthUI.HealthBarForeground.localScale.y, unitHealthUI.HealthBarForeground.localScale.z);
    }
}
