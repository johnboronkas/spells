using UnityEngine;

public class Respawner : MonoBehaviour
{
    public void Kill(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
