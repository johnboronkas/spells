using UnityEngine;

public class Mover : MonoBehaviour
{
    public MoverController MoverController;

    public int Speed;

    private void FixedUpdate()
    {
        MoverController.HandleMovement(this);
    }
}
