using UnityEngine;

public class UnitHealthUI : MonoBehaviour
{
    public UnitHealthUIController UnitHealthUIController;

    public float FloatHeight = 0.4f;
    public Transform HealthBarBackground;
    public Transform HealthBarForeground;

    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        transform.parent = null;
    }

    private void LateUpdate()
    {
        UnitHealthUIController.UpdateUnitHealthUI(this);
        Utils.CenterAboveUnit(transform, parent, FloatHeight);
    }
}
