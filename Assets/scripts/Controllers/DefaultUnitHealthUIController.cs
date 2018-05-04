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
        Debug.Log(Health.CurrentHealth);

        unitHealthUI.HealthBarBackground.localScale = new Vector3(Health.MaxHealth / 2, unitHealthUI.HealthBarBackground.localScale.y, unitHealthUI.HealthBarBackground.localScale.z);
        unitHealthUI.HealthBarForeground.localScale = new Vector3(Health.CurrentHealth / 2, unitHealthUI.HealthBarForeground.localScale.y, unitHealthUI.HealthBarForeground.localScale.z);
    }
}
