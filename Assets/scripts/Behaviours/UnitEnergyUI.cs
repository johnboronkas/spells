using System.Collections;
using UnityEngine;

public class UnitEnergyUI : MonoBehaviour
{
    public UnitEnergyUIController UnitEnergyUIController;

    public float FloatHeight = 0.35f;
    public Transform EnergyBarBackground;
    public Transform EnergyBarForeground;

    private void LateUpdate()
    {
        UnitEnergyUIController.UpdateUnitEnergyUI(this);
        Utils.CenterOnUnit(transform, transform.parent, FloatHeight);
    }
}
