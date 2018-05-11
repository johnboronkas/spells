using UnityEngine;

public class UnitHealthUI : MonoBehaviour
{
    public UnitHealthUIController UnitHealthUIController;

    public float FloatHeight = 0.4f;
    public Transform HealthBarBackground;
    public Transform HealthBarForeground;

    private void LateUpdate()
    {
        UnitHealthUIController.UpdateUnitHealthUI(this);
        Utils.CenterOnUnit(transform, transform.parent, FloatHeight);
    }
}
