using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed;
    void Update()
    {
        transform.Translate(Vector2.left * obstacleSpeed * Time.deltaTime);
    }
}
