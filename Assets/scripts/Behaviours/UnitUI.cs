using UnityEngine;

public class UnitUI : MonoBehaviour
{
    public UnitUIController UnitUIControllerDef;
    
    public string UnitName;

    private void LateUpdate()
    {
        CenterAboveUnit();
        UnitUIControllerDef.UpdateUnitUI(this);
    }

    private void CenterAboveUnit()
    {
        // TODO PICKUP FIX
        transform.rotation = Quaternion.identity;
    }
}
