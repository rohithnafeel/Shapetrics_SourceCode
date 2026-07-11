using UnityEngine;

public class ShapeController : MonoBehaviour
{
    public enum Shape
    {
        Square,
        Triangle,
        Circle,
        Hexagon
    }

    public Shape currentShape;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Obstacle obstacle = other.GetComponent<Obstacle>();

        if (obstacle != null)
        {
            if (currentShape == obstacle.obstacleShape)
            {
                Debug.Log("Correct!");
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("Game Over!");
            }
        }
    }
}