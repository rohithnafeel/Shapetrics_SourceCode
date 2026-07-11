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

        currentShape = ShapeType.Square;
        sr.sprite = square;
        sr.color = new Color(0f, 1f, 1f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentShape = ShapeType.Square;
            sr.sprite = square;
            sr.color = new Color(0f, 1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            currentShape = ShapeType.Triangle;
            sr.sprite = triangle;
            sr.color = new Color(1f, 0f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentShape = ShapeType.Circle;
            sr.sprite = circle;
            sr.color = new Color(0f, 1f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            currentShape = ShapeType.Hexagon;
            sr.sprite = hexagon;
            sr.color = new Color(0.5f, 0f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Obstacle obstacle = other.GetComponent<Obstacle>();

        if (obstacle != null)
        {
            if (currentShape == obstacle.obstacleShape)
            {
                GameManager.Instance.AddScore();
                Destroy(other.gameObject);
            }
            else
            {
                Time.timeScale = 0f;
            }
        }
    }
}