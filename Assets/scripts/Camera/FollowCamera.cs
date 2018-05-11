using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FollowCamera : MonoBehaviour
{
    public GameObject FollowTarget;
    public float MinOrthoSize;
    public float MaxOrthoSize;
    public float FollowTargetSearchInterval = 0.5f;

    private Camera Camera;
    private Vector3 Offset;
    private float NextSearchTime;

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
        if (FollowTarget == null && NextSearchTime <= Time.time)
        {
            FollowTarget = GameObject.FindGameObjectWithTag(Tags.Player);
            NextSearchTime = Time.time + NextSearchTime;
        }

        transform.position = FollowTarget.transform.position + Offset;
	}
}
