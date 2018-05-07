using UnityEngine;

public class Mover : MonoBehaviour
{
    public MoverController MoverController;

    public int Speed = 2000;

    private void FixedUpdate()
    {
        MoverController.HandleMovement(this);
    }
}
