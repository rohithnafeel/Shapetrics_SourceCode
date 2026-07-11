using UnityEngine;

public class ShapeController : MonoBehaviour
{
    public ShapeType currentShape;

    public Sprite square;
    public Sprite triangle;
    public Sprite circle;
    public Sprite hexagon;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentShape = ShapeType.Circle;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentShape = ShapeType.Square;
            sr.sprite = square;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            currentShape = ShapeType.Triangle;
            sr.sprite = triangle;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentShape = ShapeType.Circle;
            sr.sprite = circle;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            currentShape = ShapeType.Hexagon;
            sr.sprite = hexagon;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Obstacle obstacle = other.GetComponent<Obstacle>();

        if (obstacle != null)
        {
            Debug.Log("Player shape: " + currentShape);
            Debug.Log("Obstacle shape: " + obstacle.obstacleShape);

            if (currentShape == obstacle.obstacleShape)
            {
                Debug.Log("MATCH!");

                GameManager.Instance.AddScore();

                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("NO MATCH!");

                Time.timeScale = 0f;
            }
        }
    }
}