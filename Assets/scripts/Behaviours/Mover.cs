using UnityEngine;

public class Mover : MonoBehaviour
{
    public MoverController MoverController;

    public int MaxSpeed; // 2000

    public int CurrentSpeed;

    private void FixedUpdate()
    {
        MoverController.HandleMovement(this);
    }
}
