using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private float spawnX = 8f;
    [SerializeField] private float yRange = 2f;
    
    [SerializeField] private float startSpeed = 3f;
    [SerializeField] private float speedGrowth = 0.2f;
    [SerializeField] private float maxSpeed = 10f;

    private float _currentSpeed;
    private float _timer;

    void Start()
    {
        _currentSpeed = startSpeed;
    }

    void Update()
    {
        if (_currentSpeed < maxSpeed)
        {
            _currentSpeed += speedGrowth * Time.deltaTime;
        }

        _timer += Time.deltaTime;
        
        if (_timer >= spawnInterval)
        {
            float randomY = Random.Range(-yRange, yRange);
            Vector3 spawnPos = new Vector3(spawnX, randomY, 0f);
            GameObject newObstacle = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
            
            newObstacle.GetComponent<ObstacleMovement>().SetSpeed(_currentSpeed);
            
            _timer = 0f;
        }
    }
}
