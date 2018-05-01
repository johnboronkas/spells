﻿using UnityEngine;

public class UnitNameUI : MonoBehaviour
{
    public UnitNameUIController UnitNameUIControllerDef;
    
    public string UnitName;
    public float FloatHeight; // 0.3f

    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        transform.parent = null;
    }

    private void LateUpdate()
    {
        UnitNameUIControllerDef.UpdateUnitNameUI(this);
        CenterAboveUnit();
    }

    private void CenterAboveUnit()
    {
        transform.position = parent.position + (Vector3.up * FloatHeight);
    }
}