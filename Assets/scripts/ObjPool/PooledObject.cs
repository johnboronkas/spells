using UnityEngine;

/// <summary>
/// Currently unused.
/// </summary>
public class PooledObject : MonoBehaviour
{
    [System.NonSerialized]
    public ObjectPool ObjectPool;

    public T GetPooledInstance<T>() where T : PooledObject
    {
        if (!ObjectPool)
        {
            ObjectPool = ObjectPool.GetPool(this);
        }

        return (T)ObjectPool.GetObject();
    }

    public void ReturnToPool()
    {
        if (ObjectPool)
        {
            ObjectPool.AddObject(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
