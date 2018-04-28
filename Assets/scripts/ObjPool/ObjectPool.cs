using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Currently unused.
/// </summary>
public class ObjectPool : MonoBehaviour
{
    public PooledObject Prefab;
    private List<PooledObject> AvailableObjects;

    public ObjectPool()
    {
        AvailableObjects = new List<PooledObject>();
    }

    public static ObjectPool GetPool(PooledObject prefab)
    {
        var poolName = prefab.name + " Pool";

        GameObject obj;
        ObjectPool pool;

        if (Application.isEditor)
        {
            obj = GameObject.Find(poolName);
            if (obj)
            {
                pool = obj.GetComponent<ObjectPool>();
                if (pool)
                {
                    return pool;
                }
            }
        }

        obj = new GameObject(poolName);
        pool = obj.AddComponent<ObjectPool>();
        pool.Prefab = prefab;
        return pool;
    }

    public PooledObject GetObject()
    {
        PooledObject obj;
        int lastAvailableIndex = AvailableObjects.Count - 1;
        if (lastAvailableIndex >= 0)
        {
            obj = AvailableObjects[lastAvailableIndex];
            AvailableObjects.RemoveAt(lastAvailableIndex);
            obj.gameObject.SetActive(true);
        }
        else
        {
            obj = Instantiate<PooledObject>(Prefab);
            obj.transform.SetParent(transform, false);
            obj.ObjectPool = this;
        }
        
        return obj;
    }

    public void AddObject(PooledObject obj)
    {
        obj.gameObject.SetActive(false);
        AvailableObjects.Add(obj);
    }
}
