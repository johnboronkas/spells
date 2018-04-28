using UnityEngine;

public abstract class MoverController : MonoBehaviour
{
    public abstract void HandleMovement(int currentSprintSpeed, int currentSpeed);
    public abstract void HandleRotation();
}
