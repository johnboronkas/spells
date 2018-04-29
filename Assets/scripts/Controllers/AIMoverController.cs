using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AIMoverController : MoverController
{
    private Rigidbody2D Rigidbody2D;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public override void HandleMovement(int currentSprintSpeed, int currentSpeed)
    {
        
    }
}
