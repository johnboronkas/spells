using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    protected float ProjectileSpawnDistance = 0.2f;

    public abstract void Activate(Transform transform);
}
