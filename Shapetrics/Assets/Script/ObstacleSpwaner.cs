using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnObstacle),
            1f,
            spawnInterval
        );
    }

    void SpawnObstacle()
    {
        GameObject obstacleObject =
            Instantiate(
                obstaclePrefab,
                transform.position,
                Quaternion.identity
            );

        Obstacle obstacle =
            obstacleObject.GetComponent<Obstacle>();

        ShapeType randomShape =
    (ShapeType)Random.Range(0, 4);

        obstacle.SetShape(randomShape);
    }
}