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
        // TODO Display health bar somehow.
        Debug.Log(Health.CurrentHealth);
    }
}
