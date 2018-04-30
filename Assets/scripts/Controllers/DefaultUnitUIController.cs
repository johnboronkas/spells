using UnityEngine;

[RequireComponent(typeof(TextMesh))]
[RequireComponent(typeof(MeshRenderer))]
public class DefaultUnitUIController : UnitUIController
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

    public override void UpdateUnitUI(UnitUI unitUI)
    {
        NameTextMesh.text = unitUI.UnitName;
    }
}
