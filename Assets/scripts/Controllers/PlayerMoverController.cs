using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMoverController : MoverController
{
    private Rigidbody2D Rigidbody2D;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public override void HandleMovement(Mover mover)
    {
        float speed = mover.Speed * Time.deltaTime;
        float horizonal = Input.GetAxis(InputManager.Horizontal);
        float vertical = Input.GetAxis(InputManager.Vertical);

        Vector2 inputForce = new Vector2(horizonal, vertical);
        inputForce.Normalize();

        Rigidbody2D.AddForce(
            (inputForce * speed),
            ForceMode2D.Force
        );
    }
}
