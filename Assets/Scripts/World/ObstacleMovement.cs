using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed;
    [SerializeField] private float deleteZone = -8f;
    
    void Update()
    {
        transform.Translate(Vector2.left * obstacleSpeed * Time.deltaTime);
        
        if (transform.position.x <= deleteZone)
        {
            Destroy(gameObject);
        }
    }
    
    public void SetSpeed(float speed)
    {
        obstacleSpeed = speed;
    }
}
