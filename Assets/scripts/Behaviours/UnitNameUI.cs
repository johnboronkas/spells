using UnityEngine;

public class UnitNameUI : MonoBehaviour
{
    public UnitNameUIController UnitNameUIController;
    
    public string UnitName = "Default";
    public float FloatHeight = 0.5f;

    private void LateUpdate()
    {
        UnitNameUIController.UpdateUnitNameUI(this);
        Utils.CenterOnUnit(transform, transform.parent, FloatHeight);
    }
}
