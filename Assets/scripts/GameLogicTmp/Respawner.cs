using UnityEngine;

// TODO move out to prefab
public class Respawner : MonoBehaviour
{
    public void Kill(GameObject gameObject)
    {
        Destroy(gameObject);
    }
}
