using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
    public GameObject FollowTarget;
    public float MinOrthoSize;
    public float MaxOrthoSize;

    private Camera Camera;
    private Vector3 Offset;

	private void Start()
    {
        Camera = GetComponent<Camera>();
        Offset = transform.position - FollowTarget.transform.position; // May need to move this to late update, use bool to detect if a new follow target was selected and use it.
	}

    private void Update()
    {
        Camera.orthographicSize = (Camera.orthographicSize + Input.GetAxis(InputManager.Camera_Zoom)).Bound(MinOrthoSize, MaxOrthoSize);
    }

    private void LateUpdate()
    {
        if (FollowTarget == null) return;

        transform.position = FollowTarget.transform.position + Offset;
	}
}
