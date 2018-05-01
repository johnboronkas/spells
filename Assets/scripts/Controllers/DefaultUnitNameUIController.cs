using UnityEngine;

[RequireComponent(typeof(TextMesh))]
[RequireComponent(typeof(MeshRenderer))]
public class DefaultUnitNameUIController : UnitNameUIController
{
    private TextMesh NameTextMesh;
    private MeshRenderer NameMeshRenderer;

    private void Start()
    {
        NameTextMesh = GetComponent<TextMesh>();
        NameMeshRenderer = GetComponent<MeshRenderer>();

        NameMeshRenderer.sortingLayerName = "ui";
        NameMeshRenderer.sortingOrder = 0;
    }

    public override void UpdateUnitNameUI(UnitNameUI unitNameUI)
    {
        NameTextMesh.text = unitNameUI.UnitName;
    }
}
