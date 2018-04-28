using UnityEngine;

public class Mover : MonoBehaviour
{
    public MoverController MoverController;

    public int MaxSpeed; // 2000
    public int MaxSprintSpeed; // 5000

    public int CurrentSpeed;
    public int CurrentSprintSpeed;

    private void FixedUpdate()
    {
        MoverController.HandleMovement(CurrentSprintSpeed, CurrentSpeed);
    }
}
