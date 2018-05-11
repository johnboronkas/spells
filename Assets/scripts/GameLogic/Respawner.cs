using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject FriendlyPrefab;
    public GameObject EnemyPrefab;
    public SpawnPoint[] SpawnPoints;

    private System.Random Rand;

    private void Start()
    {
        Rand = new System.Random();
    }

    public void Kill(GameObject gameObject)
    {
        Destroy(gameObject);
        Instantiate(GetFreshPrefabByTag(gameObject), GetRandomSpawnPointPosition(), Quaternion.identity);
    }

    private GameObject GetFreshPrefabByTag(GameObject taggedGameObject)
    {
        if (taggedGameObject.CompareTag(Tags.Player))
        {
            return PlayerPrefab;
        }
        else if (taggedGameObject.CompareTag(Tags.Friendly))
        {
            return FriendlyPrefab;
        }
        else
        {
            return EnemyPrefab;
        }
    }

    private Vector3 GetRandomSpawnPointPosition()
    {
        SpawnPoint spawnPoint = SpawnPoints[Rand.Next(SpawnPoints.Length)];
        Transform spawnTransform = spawnPoint.transform;
        float x = Utils.GetRandomPos(spawnTransform.position.x, -spawnPoint.SpawnRadius, spawnPoint.SpawnRadius);
        float y = Utils.GetRandomPos(spawnTransform.position.y, -spawnPoint.SpawnRadius, spawnPoint.SpawnRadius);
        return new Vector3(x, y, spawnTransform.position.z);
    }
}
