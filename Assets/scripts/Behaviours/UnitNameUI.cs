using UnityEngine;

public class UnitNameUI : MonoBehaviour
{
    public UnitNameUIController UnitNameUIController;
    
    public string UnitName = "Default";
    public float FloatHeight = 0.5f;

    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        transform.parent = null;
    }

    private void LateUpdate()
    {
        UnitNameUIController.UpdateUnitNameUI(this);
        Utils.CenterAboveUnit(transform, parent, FloatHeight);
    }
}
