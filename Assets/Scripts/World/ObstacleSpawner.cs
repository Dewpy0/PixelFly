using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float spawnX = 8f;
    [SerializeField] private float yRange = 2f;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= spawnInterval)
        {
            float randomY = Random.Range(-yRange, yRange);
            Vector3 spawnPos = new Vector3(spawnX, randomY, 0f);
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
            _timer = 0f;
        }
    }
}
