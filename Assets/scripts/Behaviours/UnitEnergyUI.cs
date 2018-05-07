using UnityEngine;

public class UnitEnergyUI : MonoBehaviour
{
    public UnitEnergyUIController UnitEnergyUIController;

    public float FloatHeight = 0.35f;
    public Transform EnergyBarBackground;
    public Transform EnergyBarForeground;

    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        transform.parent = null;
    }

    private void LateUpdate()
    {
        UnitEnergyUIController.UpdateUnitEnergyUI(this);
        Utils.CenterAboveUnit(transform, parent, FloatHeight);
    }
}
